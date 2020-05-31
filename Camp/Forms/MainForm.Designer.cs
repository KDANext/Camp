namespace Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вожатыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.детиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интересыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(689, 448);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(726, 46);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(149, 41);
            this.buttonAddGroup.TabIndex = 2;
            this.buttonAddGroup.Text = "Добавить группу";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMatch);
            this.panel1.Controls.Add(this.buttonEditGroup);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.buttonAddGroup);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 479);
            this.panel1.TabIndex = 3;
            // 
            // buttonMatch
            // 
            this.buttonMatch.Location = new System.Drawing.Point(726, 172);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(149, 41);
            this.buttonMatch.TabIndex = 4;
            this.buttonMatch.Text = "Подобрать вожатых к группам";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Location = new System.Drawing.Point(726, 108);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(149, 41);
            this.buttonEditGroup.TabIndex = 3;
            this.buttonEditGroup.Text = "Редактировать группу";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вожатыеToolStripMenuItem,
            this.детиToolStripMenuItem,
            this.интересыToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // вожатыеToolStripMenuItem
            // 
            this.вожатыеToolStripMenuItem.Name = "вожатыеToolStripMenuItem";
            this.вожатыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вожатыеToolStripMenuItem.Text = "Вожатые";
            this.вожатыеToolStripMenuItem.Click += new System.EventHandler(this.вожатыеToolStripMenuItem_Click);
            // 
            // детиToolStripMenuItem
            // 
            this.детиToolStripMenuItem.Name = "детиToolStripMenuItem";
            this.детиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.детиToolStripMenuItem.Text = "Дети";
            this.детиToolStripMenuItem.Click += new System.EventHandler(this.детиToolStripMenuItem_Click);
            // 
            // интересыToolStripMenuItem
            // 
            this.интересыToolStripMenuItem.Name = "интересыToolStripMenuItem";
            this.интересыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.интересыToolStripMenuItem.Text = "Интересы";
            this.интересыToolStripMenuItem.Click += new System.EventHandler(this.интересыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Группы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вожатыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem детиToolStripMenuItem;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.ToolStripMenuItem интересыToolStripMenuItem;
    }
}

