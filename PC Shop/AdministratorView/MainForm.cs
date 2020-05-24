using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Database_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AdminBusinessLogic adminLogic;
        private readonly IOrderLogic orderLogic;
        private readonly IRequestLogic requestLogic;
        public MainForm(AdminBusinessLogic adminLogic, IOrderLogic orderLogic, IRequestLogic requestLogic)
        {
            InitializeComponent();
            this.adminLogic = adminLogic;
            this.orderLogic = orderLogic;
            this.requestLogic = requestLogic;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadRequests();
        }

        private void LoadOrders()
        {
            try
            {
                List<OrderViewModel> ordersList = orderLogic.Read(null);
                if (ordersList != null)
                {
                    ordersGridView.DataSource = ordersList;
                    ordersGridView.Columns[0].Visible = false;
                    ordersGridView.Columns[1].Visible = false;
                    ordersGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Ошибка загрузки списка заказов",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRequests()
        {
            try
            {
                List<RequestViewModel> requestsList = requestLogic.Read(null);
                if (requestsList != null)
                {
                    if (requestsList != null)
                    {
                        requestsGridView.DataSource = requestsList;
                        requestsGridView.Columns[0].Visible = false;
                        requestsGridView.Columns[1].Visible = false;
                        requestsGridView.Columns[4].Visible = false;
                        requestsGridView.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка загрузки списка заявок",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ComputersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComputersManagementForm>();
            form.ShowDialog();
        }

        private void ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComponentsManagementForm>();
            form.ShowDialog();
        }

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<SuppliersListForm>();
            form.ShowDialog();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<OrderCreationForm>();
            form.ShowDialog();
            LoadOrders();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<RequestCreationForm>();
            form.ShowDialog();
            LoadRequests();
        }

        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<SupplierCreationForm>();
            form.ShowDialog();
        }
    }
}
