using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;


namespace AdministratorView
{
    public partial class ComponentCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IComponentLogic logic;
        public int ID { set { Id = value; } }
        private int? Id;

        public ComponentCreationForm(IComponentLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void ComponentCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var componentView = logic.Read(new ComponentBindingModel { ID = Id })?[0];
                    if (componentView != null)
                    {
                        componentNameTextBox.Text = componentView.Name;
                        componentPriceTextBox.Text = componentView.Price.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка загрузки комплектующих",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(componentNameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Название\" не заполнено", 
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(componentPriceTextBox.Text))
            {
                MessageBox.Show(
                    "Поле \"Цена\" не заполнено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ComponentBindingModel
                {
                    ID = Id,
                    Name = componentNameTextBox.Text,
                    Price = Convert.ToDecimal(componentPriceTextBox.Text)
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
                    "Ошибка при сохранении комплектующего", 
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
