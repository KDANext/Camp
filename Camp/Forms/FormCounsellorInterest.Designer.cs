namespace Forms
{
    partial class FormCounsellorInterest
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
            this.comboBoxInterest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxInterest
            // 
            this.comboBoxInterest.FormattingEnabled = true;
            this.comboBoxInterest.Location = new System.Drawing.Point(93, 22);
            this.comboBoxInterest.Name = "comboBoxInterest";
            this.comboBoxInterest.Size = new System.Drawing.Size(164, 21);
            this.comboBoxInterest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Интерес";
            // 
            // FormCounsellorInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 92);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInterest);
            this.Name = "FormCounsellorInterest";
            this.Text = "FormCounsellorInterest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInterest;
        private System.Windows.Forms.Label label2;
    }
}