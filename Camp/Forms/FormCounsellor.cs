using BusinessLogic.Models;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormCounsellor : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly CounsellorLogic logic;
        private int? id;
        private Dictionary<int, string> counsellorInterests;
        public Dictionary<int, (int, int, int)> counsellorExperience { get; set; }       
        public FormCounsellor(CounsellorLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormComputer_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CounsellorViewModel view = logic.Read(new CounsellorBindingModel { Id = id.Value })?[0];

                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        counsellorInterests = view.CounsellorInterests;
                        counsellorExperience = view.CounsellorExperience;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                counsellorInterests = new Dictionary<int, string>();
                counsellorExperience = new Dictionary<int, (int, int, int)>();
            }
        }

        private void LoadData()
        {
            dataGridViewInterests.Columns.Clear();
            dataGridViewInterests.Columns.Add("Id", "Id");
            dataGridViewInterests.Columns.Add("Interest", "Интерес");
            dataGridViewInterests.Columns[0].Visible = false;
            dataGridViewInterests.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            try
            {
                if (counsellorInterests != null)
                {
                    dataGridViewInterests.Rows.Clear();
                    foreach (var ad in counsellorInterests)
                    {
                        dataGridViewInterests.Rows.Add(new object[] { ad.Key, ad.Value });
                    }
                }
                if (counsellorExperience != null)
                {
                    dataGridViewInterests.Rows.Clear();
                    foreach (var ad in counsellorInterests)
                    {
                        dataGridViewInterests.Rows.Add(new object[] { ad.Key, ad.Value });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddInterest_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCounsellorInterest>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (counsellorInterests.ContainsKey(form.Id))
                {
                    counsellorInterests[form.Id] = form.InterestName;
                }
                else
                {
                    counsellorInterests.Add(form.Id, form.InterestName);
                }
                LoadData();
            }
        }

        private void buttonAddExp_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCounsellorExperience>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (counsellorExperience.ContainsKey(form.Id))
                {
                    counsellorExperience[form.Id] = (form.AgeFrom, form.AgeTo, form.Years);
                }
                else
                {
                    counsellorExperience.Add(form.Id, (form.AgeFrom, form.AgeTo, form.Years));
                }
                LoadData();
            }
        }

        private void buttonUpdInterests_Click(object sender, EventArgs e)
        {
            if (dataGridViewInterests.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormCounsellorInterest>();
                int id = Convert.ToInt32(dataGridViewInterests.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    counsellorInterests[form.Id] = form.InterestName;
                    LoadData();
                }
            }
        }

        private void buttonUpdExp_Click(object sender, EventArgs e)
        {
            if (dataGridViewExperience.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormCounsellorExperience>();
                int id = Convert.ToInt32(dataGridViewExperience.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    counsellorExperience[form.Id] = (form.AgeFrom, form.AgeTo, form.Years);
                    LoadData();
                }
            }
        }

        private void buttonDelInterest_Click(object sender, EventArgs e)
        {
            if (dataGridViewInterests.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        counsellorInterests.Remove(Convert.ToInt32(dataGridViewInterests.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadData();
                }
            }
        }

        private void buttonDelExp_Click(object sender, EventArgs e)
        {
            if (dataGridViewExperience.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        counsellorExperience.Remove(Convert.ToInt32(dataGridViewExperience.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadData();
                }
            }
        }        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (counsellorInterests == null || counsellorInterests.Count == 0)
            {
                MessageBox.Show("Заполните интересы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new CounsellorBindingModel
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    CounsellorInterests = counsellorInterests,
                    CounsellorExperience = counsellorExperience
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; Close();
        }

    }
}
