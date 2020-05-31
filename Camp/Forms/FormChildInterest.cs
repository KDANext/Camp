using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormChildInterest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(comboBoxInterest.SelectedValue); }
            set { comboBoxInterest.SelectedValue = value; }
        }
        public string InterestName { get { return comboBoxInterest.Text; } }       
        public FormChildInterest(InterestLogic logic)
        {
            InitializeComponent();
            List<InterestViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxInterest.DisplayMember = "Interest";
                comboBoxInterest.ValueMember = "Id";
                comboBoxInterest.DataSource = list;
                comboBoxInterest.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {            
            if (comboBoxInterest.SelectedValue == null)
            {
                MessageBox.Show("Выберите интерес", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
