using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormChild : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly ChildLogic logic;
        private int? id;
        private Dictionary<int, string> childInterests;

        public FormChild(ChildLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ChildViewModel view = logic.Read(null).Where(x => x.Id == id).First();

                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        textBoxAge.Text = view.Age.ToString();
                        childInterests = view.ChildInterests;
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
                childInterests = new Dictionary<int, string>();
            }
        }

        private void LoadData()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Interest", "Интерес");            
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            try
            {
                if (childInterests != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var interest in childInterests)
                    {
                        dataGridView.Rows.Add(new object[] { interest.Key, interest.Value });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormChildInterest>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (childInterests.ContainsKey(form.Id))
                {
                    childInterests[form.Id] = form.InterestName;
                }
                else
                {
                    childInterests.Add(form.Id, form.InterestName);
                }
                LoadData();
            }
        }
               

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        childInterests.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
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

            if (string.IsNullOrEmpty(textBoxAge.Text))
            {
                MessageBox.Show("Заполните возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (childInterests == null || childInterests.Count == 0)
            {
                MessageBox.Show("Заполните интересы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                logic.CreateOrUpdate(new ChildBindingModel
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    Age = Convert.ToInt32(textBoxAge.Text),
                    ChildInterests = childInterests
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
