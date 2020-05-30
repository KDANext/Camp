using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormGroupChild : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get { return Convert.ToInt32(comboBoxAddChild.SelectedValue); }
            set { comboBoxAddChild.SelectedValue = value; }
        }
        public string ChildName { get { return comboBoxAddChild.Text; } }
        
        public FormGroupChild(GroupLogic logic)
        {
            InitializeComponent();
            List<GroupViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxAddChild.DisplayMember = "ChildName";
                comboBoxAddChild.ValueMember = "Id";
                comboBoxAddChild.DataSource = list;
                comboBoxAddChild.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {           
            if (comboBoxAddChild.SelectedValue == null)
            {
                MessageBox.Show("Выберите ребёнка", "Ошибка", MessageBoxButtons.OK,
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
