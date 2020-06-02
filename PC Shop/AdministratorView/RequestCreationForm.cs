using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Business_Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class RequestCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IRequestLogic requestLogic;
        private readonly ISupplierLogic supplierLogic;
        private readonly AdminBusinessLogic adminBusinessLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        private Dictionary<int, (string, int, bool)> requestComponents;

        public RequestCreationForm(AdminBusinessLogic adminBusinessLogic,
            IRequestLogic requestLogic, ISupplierLogic supplierLogic)
        {
            InitializeComponent();
            this.requestLogic = requestLogic;
            this.supplierLogic = supplierLogic;
            this.adminBusinessLogic = adminBusinessLogic;
        }

        private void RequestCreationForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            if (Id.HasValue)
            {
                try
                {
                    RequestViewModel request = requestLogic.Read(new RequestBindingModel
                    {
                        ID = Id.Value
                    })?[0];
                    if (request != null)
                    {
                        supplierComboBox.SelectedIndex = 
                            supplierComboBox.FindStringExact(request.SupplierLogin);
                        requestComponents = request.Components;
                        LoadComponents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка загрузки данных заявки",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                requestComponents = new Dictionary<int, (string, int, bool)>();
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                List<SupplierViewModel> suppliersList = supplierLogic.Read(null);
                if (suppliersList != null)
                {
                    supplierComboBox.DisplayMember = "Login";
                    supplierComboBox.ValueMember = "ID";
                    supplierComboBox.DataSource = suppliersList;
                    supplierComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка загрузки списка поставщиков",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadComponents()
        {
            try
            {
                if (requestComponents != null)
                {
                    componentsGridView.Rows.Clear();
                    foreach (var requestComponent in requestComponents)
                    {
                        componentsGridView.Rows.Add(new object[] {
                            requestComponent.Key,
                            requestComponent.Value.Item1,
                            requestComponent.Value.Item2
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка загрузки комплектующих",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddComponentButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComponentAddingForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (requestComponents.ContainsKey(form.ID))
                {
                    requestComponents[form.ID] = (form.ComponentName, form.Count, false);
                }
                else
                {
                    requestComponents.Add(form.ID, (form.ComponentName, form.Count, false));
                }
                LoadComponents();
            }
        }

        private void UpdateComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<ComponentAddingForm>();
                int ID = Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value);
                form.ID = ID;
                form.Count = requestComponents[ID].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    requestComponents[form.ID] = (form.ComponentName, form.Count, false);
                    LoadComponents();
                }
            }
        }

        private void DeleteComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить комплектующее?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        requestComponents.Remove(Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadComponents();
                }
            }
        }

        private void RefreshComponentsButton_Click(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (supplierComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Поставщик не выбран",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (requestComponents == null || requestComponents.Count == 0)
            {
                MessageBox.Show(
                    "Не выбрано ни одного комплектующего",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                adminBusinessLogic.CreateOrUpdateRequest(new RequestBindingModel
                {
                    ID = Id,
                    SupplierID = Convert.ToInt32(supplierComboBox.SelectedValue),
                    Components = requestComponents
                });
                MessageBox.Show(
                    "Сохранение заявки прошло успешно",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void СancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
