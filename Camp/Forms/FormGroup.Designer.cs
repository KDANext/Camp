namespace Forms
{
    partial class FormGroup
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxChildren = new System.Windows.Forms.ListBox();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAddChild = new System.Windows.Forms.ComboBox();
            this.textBoxCounsellor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(68, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // listBoxChildren
            // 
            this.listBoxChildren.FormattingEnabled = true;
            this.listBoxChildren.Location = new System.Drawing.Point(382, 53);
            this.listBoxChildren.Name = "listBoxChildren";
            this.listBoxChildren.Size = new System.Drawing.Size(201, 212);
            this.listBoxChildren.TabIndex = 3;
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Location = new System.Drawing.Point(68, 50);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(157, 22);
            this.textBoxProfile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список детей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Профиль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавить ребёнка";
            // 
            // comboBoxAddChild
            // 
            this.comboBoxAddChild.FormattingEnabled = true;
            this.comboBoxAddChild.Location = new System.Drawing.Point(404, 13);
            this.comboBoxAddChild.Name = "comboBoxAddChild";
            this.comboBoxAddChild.Size = new System.Drawing.Size(170, 21);
            this.comboBoxAddChild.TabIndex = 8;
            // 
            // textBoxCounsellor
            // 
            this.textBoxCounsellor.Location = new System.Drawing.Point(68, 87);
            this.textBoxCounsellor.Name = "textBoxCounsellor";
            this.textBoxCounsellor.Size = new System.Drawing.Size(157, 22);
            this.textBoxCounsellor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вожатый";
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCounsellor);
            this.Controls.Add(this.comboBoxAddChild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProfile);
            this.Controls.Add(this.listBoxChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormGroup";
            this.Text = "Группа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxChildren;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAddChild;
        private System.Windows.Forms.TextBox textBoxCounsellor;
        private System.Windows.Forms.Label label5;
    }
}