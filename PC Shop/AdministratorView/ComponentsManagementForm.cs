using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class ComponentsManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IComponentLogic logic;
        public ComponentsManagementForm(IComponentLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void ComponentsManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var componentsList = logic.Read(null);
                if (componentsList != null)
                {
                    componentsGridView.DataSource = componentsList;
                    componentsGridView.Columns[0].Visible = false;
                    componentsGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Ошибка загрузки списка комплектующих", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ComponentCreationForm form = Container.Resolve<ComponentCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (componentsGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<ComponentCreationForm>();
                form.ID = Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (componentsGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить комплектующее?", 
                    "Требуется подтверждение", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int componentID = Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new ComponentBindingModel { ID = componentID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, 
                            "Не удалось удалить комплекующее", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
