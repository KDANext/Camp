using BusinessLogic.Models;
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
        public readonly ExperienceLogic logic;
        public int Id { get; set; }
        public int councellorId { get; set; }
        public int AgeFrom { get { return Convert.ToInt32(textBoxAgeFrom.Text); } }
        public int AgeTo { get { return Convert.ToInt32(textBoxAgeTo.Text); } }
        public int Years { get { return Convert.ToInt32(textBoxYears.Text); } }           

        public FormCounsellorExperience(ExperienceLogic logic)
        {
            this.logic = logic;
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
            logic.CreateOrUpdate(new ExperienceBindingModel
            {
                CounsellorId = this.councellorId,
                AgeFrom = Convert.ToInt32(textBoxAgeFrom.Text),
                AgeTo = Convert.ToInt32(textBoxAgeTo.Text),
                Years = Convert.ToInt32(textBoxYears.Text)
            });
            Id = logic.Read(new ExperienceBindingModel
            {
                CounsellorId = this.councellorId,
                AgeFrom = Convert.ToInt32(textBoxAgeFrom.Text),
                AgeTo = Convert.ToInt32(textBoxAgeTo.Text),
                Years = Convert.ToInt32(textBoxYears.Text)
            })[0].Id.Value;
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
