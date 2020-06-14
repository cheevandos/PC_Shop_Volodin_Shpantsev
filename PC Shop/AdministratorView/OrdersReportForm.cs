using Microsoft.Reporting.WinForms;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.Helpers;

namespace AdministratorView
{
    public partial class OrdersReportForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IOrderLogic orderLogic;
        private readonly AdminBusinessLogic businessLogic;

        public OrdersReportForm(IOrderLogic orderLogic, AdminBusinessLogic businessLogic)
        {
            InitializeComponent();
            this.orderLogic = orderLogic;
            this.businessLogic = businessLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value.Date >= endDateTimePicker.Value.Date)
            {
                MessageBox.Show(
                    "Дата начала должна быть меньше даты окончания",
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                ReportParameter parameter = new ReportParameter(
                    "ReportParameterPeriod",
                    "C " + startDateTimePicker.Value.ToShortDateString() 
                    + " по " + endDateTimePicker.Value.ToShortDateString());
                ordersReportViewer.LocalReport.SetParameters(parameter);
                var data = orderLogic.ReadForReport(new OrderBindingModel
                {
                    StartDate = startDateTimePicker.Value,
                    EndDate = endDateTimePicker.Value
                });
                ReportDataSource source = new ReportDataSource("OrdersDataSet", data);
                ordersReportViewer.LocalReport.DataSources.Add(source);
                ordersReportViewer.RefreshReport();
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

        private void ButtonToPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show(
                    "Заполните email получателя",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (startDateTimePicker.Value.Date >= endDateTimePicker.Value.Date)
            {
                MessageBox.Show(
                    "Дата начала должна быть меньше даты окончания",
                    "Ошибка",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            try
            {

                businessLogic.SaveAndSendPdf(new OrdersReportInfo
                {
                    StartDate = startDateTimePicker.Value,
                    EndDate = endDateTimePicker.Value,
                    RecipientEmail = emailTextBox.Text
                });
                MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
