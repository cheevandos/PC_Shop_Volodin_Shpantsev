using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Database_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class SupplierCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ISupplierLogic supplierLogic;
        public SupplierCreationForm(ISupplierLogic supplierLogic)
        {
            InitializeComponent();
            this.supplierLogic = supplierLogic;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Логин\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Пароль\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(fullNameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"ФИО\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                supplierLogic.CreateOrUpdate(new SupplierBindingModel
                {
                    Login = loginTextBox.Text,
                    Password = passwordTextBox.Text,
                    FullName = fullNameTextBox.Text
                });
                MessageBox.Show(
                    "Сохранение прошло успешно",
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
                    "Ошибка при сохранении поставщика",
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
