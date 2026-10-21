namespace EscolaVirtual.Forms
{
    partial class FormChangeDataTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeDataTeacher));
            this.pChange = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pChange
            // 
            this.pChange.BackColor = System.Drawing.Color.White;
            this.pChange.Controls.Add(this.lblAddress);
            this.pChange.Controls.Add(this.txtAddress);
            this.pChange.Controls.Add(this.lblPhoneNumber);
            this.pChange.Controls.Add(this.txtPhoneNumber);
            this.pChange.Controls.Add(this.lblName);
            this.pChange.Controls.Add(this.lblEmail);
            this.pChange.Controls.Add(this.txtEmail);
            this.pChange.Controls.Add(this.txtName);
            this.pChange.Controls.Add(this.btnChangeData);
            this.pChange.Controls.Add(this.btnExit);
            this.pChange.Location = new System.Drawing.Point(225, 0);
            this.pChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pChange.Name = "pChange";
            this.pChange.Size = new System.Drawing.Size(543, 377);
            this.pChange.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(67, 194);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 16);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Morada";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 213);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.MaxLength = 70;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 22);
            this.txtAddress.TabIndex = 18;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(64, 134);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(142, 16);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "Número de Telemóvel";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(67, 153);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 9;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(392, 22);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(63, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(65, 95);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackColor = System.Drawing.Color.Green;
            this.btnChangeData.Enabled = false;
            this.btnChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeData.ForeColor = System.Drawing.Color.White;
            this.btnChangeData.Location = new System.Drawing.Point(67, 289);
            this.btnChangeData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(165, 53);
            this.btnChangeData.TabIndex = 5;
            this.btnChangeData.Text = "Alterar Dados";
            this.btnChangeData.UseVisualStyleBackColor = false;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(293, 289);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormChangeDataTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1003, 375);
            this.Controls.Add(this.pChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChangeDataTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Dados do Professor";
            this.Load += new System.EventHandler(this.FormChangeDataTeacher_Load);
            this.pChange.ResumeLayout(false);
            this.pChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pChange;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
    }
}