using DatabaseImplement.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainLogic logic;
        public MainForm(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormGroup>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormGroup>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            logic.Match();
        }

        private void вожатыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCounsellors>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void детиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormChildren>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
           /* var list = logic.GetGroupsList();
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;                
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }*/
        }
    }
}
