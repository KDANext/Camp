using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormCounsellorExperience : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        //как установить id?
        public int Id
        {
            /* get { return Convert.ToInt32(comboBoxInterest.SelectedValue); }
             set { comboBoxInterest.SelectedValue = value; }*/
             // чтобы пока хоть как-то работало
            get
            {
                return -1;
            }
            set
            {

            }
        }
        public int AgeFrom { get { return Convert.ToInt32(textBoxAgeFrom.Text); } }
        public int AgeTo { get { return Convert.ToInt32(textBoxAgeTo.Text); } }
        public int Years { get { return Convert.ToInt32(textBoxYears.Text); } }           

        public FormCounsellorExperience(ExperienceLogic logic)
        {
            InitializeComponent();
            List<ExperienceViewModel> list = logic.Read(null);
            if (list != null)
            {
                textBoxAgeFrom.Text = AgeFrom.ToString();
                textBoxAgeTo.Text = AgeTo.ToString();
                textBoxYears.Text = Years.ToString();                
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxAgeFrom.Text == "" || textBoxAgeTo.Text == "" || textBoxYears.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
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
