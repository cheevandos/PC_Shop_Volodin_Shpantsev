using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AdministratorView
{
    public partial class ComponentAddingForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int ID
        {
            get { return Convert.ToInt32(componentComboBox.SelectedValue); }
            set { componentComboBox.SelectedValue = value; }
        }
        public string ComponentName { get { return componentComboBox.Text; } }
        public int Count
        {
            get { return Convert.ToInt32(countTextBox.Text); }
            set { countTextBox.Text = value.ToString(); }
        }

        public ComponentAddingForm(IComponentLogic logic)
        {
            InitializeComponent();
            List<ComponentViewModel> list = logic.Read(null);
            if (list != null)
            {
                componentComboBox.DisplayMember = "Name";
                componentComboBox.ValueMember = "ID";
                componentComboBox.DataSource = list;
                componentComboBox.SelectedItem = null;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
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
            if (componentComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Комплектующее не выбрано", 
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
