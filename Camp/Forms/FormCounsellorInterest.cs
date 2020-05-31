﻿using BusinessLogic.Enums;
using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormCounsellorInterest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(comboBoxInterest.SelectedValue); }
            set { comboBoxInterest.SelectedValue = value; }
        }
        public String InterestName { get { return comboBoxInterest.Text; } }
        public FormCounsellorInterest(InterestLogic logic)
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

        private void FormCounsellorInterest_Load(object sender, EventArgs e)
        {

        }
    }
}
