using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class ComputerCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int ID { set { Id = value; } }
        private readonly IComputerLogic computerLogic;
        private readonly IComponentLogic componentLogic;
        private int? Id;
        private const decimal costOfWork = 2000;
        private Dictionary<int, (string, int)> computerComponents;

        public ComputerCreationForm(IComputerLogic computerLogic, IComponentLogic componentLogic)
        {
            InitializeComponent();
            this.computerLogic = computerLogic;
            this.componentLogic = componentLogic;
        }

        private void ComputerCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    ComputerViewModel computer = computerLogic.Read(new ComputerBindingModel
                    {
                        ID = Id.Value
                    })?[0];
                    if (computer != null)
                    {
                        computerNameTextBox.Text = computer.Name;
                        computerPriceTextBox.Text = computer.Price.ToString();
                        computerComponents = computer.Components;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message, 
                        "Ошибка загрузки данных о ПК", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                computerComponents = new Dictionary<int, (string, int)>();
            }
        }

        private void LoadData()
        {
            try
            {
                if (computerComponents != null)
                {
                    componentsGridView.Rows.Clear();
                    foreach (var computerComponent in computerComponents)
                    {
                        componentsGridView.Rows.Add(new object[] { 
                            computerComponent.Key, 
                            computerComponent.Value.Item1, 
                            computerComponent.Value.Item2 
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Ошибка загрузки данных о ПК",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            RecalculateComputerPrice();
        }

        private void RecalculateComputerPrice()
        {
            decimal computerPrice = costOfWork;
            foreach (var computerComponent in computerComponents)
            {
                var component = componentLogic.Read(new ComponentBindingModel
                {
                    ID = computerComponent.Key
                })?[0];
                if (component != null)
                {
                    computerPrice += component.Price;
                }
            }
            computerPriceTextBox.Text = computerPrice.ToString();
        }

        private void AddComponentButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComponentAddingForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (computerComponents.ContainsKey(form.ID))
                {
                    computerComponents[form.ID] = (form.ComponentName, form.Count);
                }
                else
                {
                    computerComponents.Add(form.ID, (form.ComponentName, form.Count));
                }
                LoadData();
            }
        }

        private void UpdateComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<ComponentAddingForm>();
                int ID = Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value);
                form.ID = ID;
                form.Count = computerComponents[ID].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    computerComponents[form.ID] = (form.ComponentName, form.Count);
                    LoadData();
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
                        computerComponents.Remove(Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, 
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void RefreshComponentsButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(computerNameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Название\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(computerPriceTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Цена\" не заполнено", 
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (computerComponents == null || computerComponents.Count == 0)
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
                computerLogic.CreateOrUpdate(new ComputerBindingModel
                {
                    ID = Id,
                    Name = computerNameTextBox.Text,
                    Price = Convert.ToDecimal(computerPriceTextBox.Text),
                    Components = computerComponents
                });
                MessageBox.Show(
                    "Сохранение ПК прошло успешно", 
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
