using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Business_Logic.Interfaces;
using Unity;

namespace AdministratorView
{
    public partial class OrderCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IComputerLogic computerLogic;
        private readonly AdminBusinessLogic adminLogic;

        public OrderCreationForm(AdminBusinessLogic adminLogic, IComputerLogic computerLogic)
        {
            InitializeComponent();
            this.adminLogic = adminLogic;
            this.computerLogic = computerLogic;
        }

        private void OrderCreationForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<ComputerViewModel> computersList = computerLogic.Read(null);
                if (computersList != null)
                {
                    computerComboBox.DisplayMember = "Name";
                    computerComboBox.ValueMember = "ID";
                    computerComboBox.DataSource = computersList;
                    computerComboBox.SelectedItem = null;
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

        private void RecalculateAmount()
        {
            if (computerComboBox.SelectedValue != null &&
                !string.IsNullOrEmpty(countTextBox.Text))
            {
                try
                {
                    int Id = Convert.ToInt32(computerComboBox.SelectedValue);
                    ComputerViewModel computer = computerLogic.Read(new ComputerBindingModel
                    {
                        ID = Id
                    })?[0];
                    int count = Convert.ToInt32(countTextBox.Text);
                    amountTextBox.Text = (count * computer?.Price ?? 0).ToString();
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
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            RecalculateAmount();
        }

        private void ComputerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateAmount();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Количество\" не заполнено", 
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (computerComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Необходимо выбрать ПК из списка", 
                    "Ошибка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                adminLogic.CreateOrder(new CreateOrderBindingModel
                {
                    ComputerID = Convert.ToInt32(computerComboBox.SelectedValue),
                    Count = Convert.ToInt32(countTextBox.Text),
                    Amount = Convert.ToDecimal(amountTextBox.Text),
                });
                MessageBox.Show(
                    "Заказ сохранен", 
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

        private void UndoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
