using BusinessLogic.BindingModels;
using DatabaseImplement.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormAddInterest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly InterestLogic logic;
        private int? id;        

        public FormAddInterest(InterestLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }      
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInterest.Text))
            {
                MessageBox.Show("Заполните интерес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new InterestBindingModel
                {
                    Id = id,
                    Interest = textBoxInterest.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
