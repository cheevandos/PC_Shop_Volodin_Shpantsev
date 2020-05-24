using System;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using Unity;
using System.Windows.Forms;

namespace AdministratorView
{
    public partial class ComputersManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IComputerLogic logic;
        public ComputersManagementForm(IComputerLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void ComputersManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var computersList = logic.Read(null);
                if (computersList != null)
                {
                    computersGridView.DataSource = computersList;
                    computersGridView.Columns[0].Visible = false;
                    computersGridView.Columns[3].Visible = false;
                    computersGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Ошибка загрузки списка ПК",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComputerCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (computersGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<ComputerCreationForm>();
                form.ID = Convert.ToInt32(computersGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (computersGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить ПК?", 
                    "Требуется подтверждение", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(computersGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new ComputerBindingModel { ID = Id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, 
                            "Ошибка при попытке удаления ПК",
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
