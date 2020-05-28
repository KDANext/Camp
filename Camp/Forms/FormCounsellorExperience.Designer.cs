namespace Forms
{
    partial class FormCounsellorExperience
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgeFrom = new System.Windows.Forms.TextBox();
            this.textBoxAgeTo = new System.Windows.Forms.TextBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Опыт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Возраст детей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "От";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество лет";
            // 
            // textBoxAgeFrom
            // 
            this.textBoxAgeFrom.Location = new System.Drawing.Point(107, 41);
            this.textBoxAgeFrom.Name = "textBoxAgeFrom";
            this.textBoxAgeFrom.Size = new System.Drawing.Size(157, 22);
            this.textBoxAgeFrom.TabIndex = 10;
            // 
            // textBoxAgeTo
            // 
            this.textBoxAgeTo.Location = new System.Drawing.Point(107, 70);
            this.textBoxAgeTo.Name = "textBoxAgeTo";
            this.textBoxAgeTo.Size = new System.Drawing.Size(157, 22);
            this.textBoxAgeTo.TabIndex = 11;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Location = new System.Drawing.Point(107, 103);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(157, 22);
            this.textBoxYears.TabIndex = 12;
            // 
            // FormCounsellorExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 154);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.textBoxAgeTo);
            this.Controls.Add(this.textBoxAgeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormCounsellorExperience";
            this.Text = "FormCounsellorExperience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAgeFrom;
        private System.Windows.Forms.TextBox textBoxAgeTo;
        private System.Windows.Forms.TextBox textBoxYears;
    }
}