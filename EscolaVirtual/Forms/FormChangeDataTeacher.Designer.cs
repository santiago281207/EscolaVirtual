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
            this.pChange = new System.Windows.Forms.Panel();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.pChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pChange
            // 
            this.pChange.BackColor = System.Drawing.Color.White;
            this.pChange.Controls.Add(this.btnChangeData);
            this.pChange.Controls.Add(this.btnExit);
            this.pChange.Controls.Add(this.txtNif);
            this.pChange.Controls.Add(this.txtName);
            this.pChange.Controls.Add(this.lblName);
            this.pChange.Controls.Add(this.lblNif);
            this.pChange.Location = new System.Drawing.Point(169, 0);
            this.pChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pChange.Name = "pChange";
            this.pChange.Size = new System.Drawing.Size(407, 306);
            this.pChange.TabIndex = 0;
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackColor = System.Drawing.Color.Green;
            this.btnChangeData.Enabled = false;
            this.btnChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeData.ForeColor = System.Drawing.Color.White;
            this.btnChangeData.Location = new System.Drawing.Point(50, 235);
            this.btnChangeData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(124, 43);
            this.btnChangeData.TabIndex = 5;
            this.btnChangeData.Text = "Alterar Dados";
            this.btnChangeData.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(220, 235);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(50, 154);
            this.txtNif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(295, 20);
            this.txtNif.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(48, 139);
            this.lblNif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(24, 13);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // FormChangeDataTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(752, 305);
            this.Controls.Add(this.pChange);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChangeDataTeacher";
            this.Text = "Alterar Dados do Professor";
            this.pChange.ResumeLayout(false);
            this.pChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pChange;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNif;
    }
}