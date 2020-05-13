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
            this.dataGridViewCounsellor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCounsellor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewChildren = new System.Windows.Forms.DataGridView();
            this.buttonFornGroups = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounsellor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCounsellor
            // 
            this.dataGridViewCounsellor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCounsellor.Location = new System.Drawing.Point(15, 34);
            this.dataGridViewCounsellor.Name = "dataGridViewCounsellor";
            this.dataGridViewCounsellor.RowTemplate.Height = 24;
            this.dataGridViewCounsellor.Size = new System.Drawing.Size(268, 426);
            this.dataGridViewCounsellor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вожатые";
            // 
            // buttonAddCounsellor
            // 
            this.buttonAddCounsellor.Location = new System.Drawing.Point(15, 466);
            this.buttonAddCounsellor.Name = "buttonAddCounsellor";
            this.buttonAddCounsellor.Size = new System.Drawing.Size(149, 41);
            this.buttonAddCounsellor.TabIndex = 2;
            this.buttonAddCounsellor.Text = "Добавить вожатого";
            this.buttonAddCounsellor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewCounsellor);
            this.panel1.Controls.Add(this.buttonAddCounsellor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 510);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewChildren);
            this.panel2.Controls.Add(this.buttonFornGroups);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(324, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 510);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewChildren
            // 
            this.dataGridViewChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChildren.Location = new System.Drawing.Point(15, 34);
            this.dataGridViewChildren.Name = "dataGridViewChildren";
            this.dataGridViewChildren.RowTemplate.Height = 24;
            this.dataGridViewChildren.Size = new System.Drawing.Size(268, 426);
            this.dataGridViewChildren.TabIndex = 0;
            // 
            // buttonFornGroups
            // 
            this.buttonFornGroups.Location = new System.Drawing.Point(15, 466);
            this.buttonFornGroups.Name = "buttonFornGroups";
            this.buttonFornGroups.Size = new System.Drawing.Size(149, 41);
            this.buttonFornGroups.TabIndex = 2;
            this.buttonFornGroups.Text = "Сформировать группы";
            this.buttonFornGroups.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дети";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewGroups);
            this.panel3.Controls.Add(this.buttonEditGroup);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(635, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 510);
            this.panel3.TabIndex = 5;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(15, 34);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(268, 426);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Location = new System.Drawing.Point(15, 466);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(149, 41);
            this.buttonEditGroup.TabIndex = 2;
            this.buttonEditGroup.Text = "Редактировать группу";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Группы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounsellor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCounsellor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCounsellor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewChildren;
        private System.Windows.Forms.Button buttonFornGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.Label label3;
    }
}

