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
                    ordersGridView.Rows.Clear();
                    foreach (var order in ordersList)
                    {
                        ordersGridView.Rows.Add(new object[]
                        {
                            order.ID,
                            order.ComputerName,
                            order.Count,
                            order.Amount,
                            order.Status,
                            order.CreationDate,
                            order.CompletionDate
                        });
                    }
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
                    requestsGridView.Rows.Clear();
                    foreach (var request in requestsList)
                    {
                        requestsGridView.Rows.Add(new object[]
                        {
                            request.ID,
                            request.SupplierName,
                            request.Status
                        });
                    }
                    requestsGridView.AutoResizeColumns();
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

        private void WarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<WarehousesListForm>();
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
        }
    }
}
