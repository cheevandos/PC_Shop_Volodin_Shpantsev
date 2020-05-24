using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class SuppliersListForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ISupplierLogic supplierLogic;

        public SuppliersListForm(ISupplierLogic supplierLogic)
        {
            InitializeComponent();
            this.supplierLogic = supplierLogic;
        }

        private void SuppliersListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<SupplierViewModel> suppliersList = supplierLogic.Read(null);
                if (suppliersList != null)
                {
                    suppliersGridView.DataSource = suppliersList;
                    suppliersGridView.Columns[0].Visible = false;
                    suppliersGridView.Columns[3].Visible = false;
                    suppliersGridView.AutoResizeColumns();
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
