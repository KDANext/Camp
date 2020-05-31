namespace Forms
{
    partial class FormCounsellor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewInterests = new System.Windows.Forms.DataGridView();
            this.dataGridViewExperience = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddInterest = new System.Windows.Forms.Button();
            this.buttonDelInterest = new System.Windows.Forms.Button();
            this.buttonAddExp = new System.Windows.Forms.Button();
            this.buttonDelExp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEditExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(59, 9);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(157, 22);
            this.textBoxFIO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интересы";
            // 
            // dataGridViewInterests
            // 
            this.dataGridViewInterests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInterests.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewInterests.Name = "dataGridViewInterests";
            this.dataGridViewInterests.RowTemplate.Height = 24;
            this.dataGridViewInterests.Size = new System.Drawing.Size(261, 339);
            this.dataGridViewInterests.TabIndex = 18;
            // 
            // dataGridViewExperience
            // 
            this.dataGridViewExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperience.Location = new System.Drawing.Point(422, 86);
            this.dataGridViewExperience.Name = "dataGridViewExperience";
            this.dataGridViewExperience.RowTemplate.Height = 24;
            this.dataGridViewExperience.Size = new System.Drawing.Size(261, 339);
            this.dataGridViewExperience.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Опыт работы";
            // 
            // buttonAddInterest
            // 
            this.buttonAddInterest.Location = new System.Drawing.Point(279, 103);
            this.buttonAddInterest.Name = "buttonAddInterest";
            this.buttonAddInterest.Size = new System.Drawing.Size(100, 41);
            this.buttonAddInterest.TabIndex = 21;
            this.buttonAddInterest.Text = "Добавить ";
            this.buttonAddInterest.UseVisualStyleBackColor = true;
            this.buttonAddInterest.Click += new System.EventHandler(this.buttonAddInterest_Click);
            // 
            // buttonDelInterest
            // 
            this.buttonDelInterest.Location = new System.Drawing.Point(279, 150);
            this.buttonDelInterest.Name = "buttonDelInterest";
            this.buttonDelInterest.Size = new System.Drawing.Size(100, 41);
            this.buttonDelInterest.TabIndex = 23;
            this.buttonDelInterest.Text = "Удалить";
            this.buttonDelInterest.UseVisualStyleBackColor = true;
            this.buttonDelInterest.Click += new System.EventHandler(this.buttonDelInterest_Click);
            // 
            // buttonAddExp
            // 
            this.buttonAddExp.Location = new System.Drawing.Point(689, 103);
            this.buttonAddExp.Name = "buttonAddExp";
            this.buttonAddExp.Size = new System.Drawing.Size(99, 41);
            this.buttonAddExp.TabIndex = 24;
            this.buttonAddExp.Text = "Добавить ";
            this.buttonAddExp.UseVisualStyleBackColor = true;
            this.buttonAddExp.Click += new System.EventHandler(this.buttonAddExp_Click);
            // 
            // buttonDelExp
            // 
            this.buttonDelExp.Location = new System.Drawing.Point(689, 197);
            this.buttonDelExp.Name = "buttonDelExp";
            this.buttonDelExp.Size = new System.Drawing.Size(99, 41);
            this.buttonDelExp.TabIndex = 26;
            this.buttonDelExp.Text = "Удалить";
            this.buttonDelExp.UseVisualStyleBackColor = true;
            this.buttonDelExp.Click += new System.EventHandler(this.buttonDelExp_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(173, 451);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 41);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(44, 451);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 41);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEditExp
            // 
            this.buttonEditExp.Location = new System.Drawing.Point(689, 150);
            this.buttonEditExp.Name = "buttonEditExp";
            this.buttonEditExp.Size = new System.Drawing.Size(99, 41);
            this.buttonEditExp.TabIndex = 29;
            this.buttonEditExp.Text = "Редактировать";
            this.buttonEditExp.Click += new System.EventHandler(this.buttonUpdExperience_Click);
            // 
            // FormCounsellor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelExp);
            this.Controls.Add(this.buttonEditExp);
            this.Controls.Add(this.buttonAddExp);
            this.Controls.Add(this.buttonDelInterest);
            this.Controls.Add(this.buttonAddInterest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewExperience);
            this.Controls.Add(this.dataGridViewInterests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "FormCounsellor";
            this.Text = "Вожатый";
            this.Load += new System.EventHandler(this.FormCounsellor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewInterests;
        private System.Windows.Forms.DataGridView dataGridViewExperience;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddInterest;
        private System.Windows.Forms.Button buttonDelInterest;
        private System.Windows.Forms.Button buttonAddExp;
        private System.Windows.Forms.Button buttonDelExp;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEditExp;
    }
}