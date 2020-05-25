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

namespace Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private readonly MainLogic logic;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {

        }

        private void вожатыеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void детиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = logic.GetGroupsList();
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;                
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
