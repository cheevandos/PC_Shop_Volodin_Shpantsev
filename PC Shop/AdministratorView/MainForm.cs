using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using PC_Shop_Database_Implementation.Models;

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
                        requestsGridView.Columns[5].Visible = false;
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

        private void StartPreparingButton_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    adminLogic.StartPreparingAnOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                    LoadOrders();
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
            UpdateButtons();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                adminLogic.CompleteOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            UpdateButtons();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                adminLogic.ConfirmOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            UpdateButtons();
        }

        private void GetPaidButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                adminLogic.PayOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            UpdateButtons();
        }

        private void RefreshOrdersButton_Click(object sender, EventArgs e)
        {
            LoadOrders();
            UpdateButtons();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int requestID = Convert.ToInt32(requestsGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                adminLogic.CheckRequestStatus(new ChangeRequestStatusBindingModel 
                { 
                    RequestID = requestID 
                });
                var form = Container.Resolve<RequestCreationForm>();
                form.ID = requestID;
                form.ShowDialog();
                LoadRequests();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (requestsGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Действительно хотите удалить заявку?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int requestID = Convert.ToInt32(requestsGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        adminLogic.CheckRequestStatus(new ChangeRequestStatusBindingModel
                        {
                            RequestID = requestID
                        });
                        adminLogic.DeleteRequest(new RequestBindingModel { ID = requestID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadRequests();
                }
            }
        }

        private void RefreshRequestsButton_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void UpdateButtons()
        {
            if (ordersGridView.SelectedRows.Count == 1)
            {
                string orderStatus = ordersGridView.SelectedRows[0].Cells[5].Value.ToString();
                confirmButton.Enabled = (orderStatus == OrderStatus.Создан.ToString()) ? true : false;
                startPreparingButton.Enabled = (orderStatus == OrderStatus.Подтвержден.ToString()) ? true : false;
                completeButton.Enabled = (orderStatus == OrderStatus.Подготавливается.ToString()) ? true : false;
                getPaidButton.Enabled = (orderStatus == OrderStatus.Готов.ToString()) ? true : false;
            }
            else
            {
                confirmButton.Enabled = false;
                startPreparingButton.Enabled = false;
                completeButton.Enabled = false;
                getPaidButton.Enabled = false;
            }
        }

        private void OrdersGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateButtons();
        }

        private void OrdersGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateButtons();
        }
    }
}
