using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class FormGroup : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly GroupLogic logic;
        public int Id { set { id = value; } }        
        private int? id;
        private Dictionary<int, string> groupChildren;
       
        public FormGroup(GroupLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormGroup_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    GroupViewModel view = logic.Read(new GroupBindingModel
                    {
                        Id = id.Value
                    })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxProfile.Text = view.Profile.ToString();                          
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                groupChildren = new Dictionary<int, string>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (groupChildren != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var child in groupChildren)
                    {
                        dataGridView.Rows.Add(new object[] { child.Key, child.Value});
                    }
                }
            }
            catch (Exception ex)
            {                
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // сделать добавление через comboBox
            //при добавлении ребёнка убираем его из combobox и показываем в списке
            var form = Container.Resolve<FormGroupChild>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (groupChildren.ContainsKey(form.Id))
                {
                    groupChildren[form.Id] = form.ChildName;
                }
                else
                {
                    groupChildren.Add(form.Id, form.ChildName);
                }
                LoadData();
            }
        }
        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormGroupChild>();
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.Id = id;                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    groupChildren[form.Id] = form.ChildName;
                    LoadData();
                }
            }
        }
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        groupChildren.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }       

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxProfile.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }            
            try
            {
                logic.CreateOrUpdate(new GroupBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Profile = (Profile)Enum.Parse(typeof(Profile), "Active", true),               
                    Children = groupChildren
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
