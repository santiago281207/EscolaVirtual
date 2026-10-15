namespace EscolaVirtual.Forms
{
    partial class FormAddTeacher
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
            this.lblNif = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblVPass = new System.Windows.Forms.Label();
            this.txtVPass = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(12, 72);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(35, 20);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(12, 91);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(255, 22);
            this.txtNif.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 139);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(255, 22);
            this.txtPass.TabIndex = 4;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 120);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(84, 20);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // lblVPass
            // 
            this.lblVPass.AutoSize = true;
            this.lblVPass.Location = new System.Drawing.Point(12, 173);
            this.lblVPass.Name = "lblVPass";
            this.lblVPass.Size = new System.Drawing.Size(155, 20);
            this.lblVPass.TabIndex = 6;
            this.lblVPass.Text = "Vereficar Password";
            // 
            // txtVPass
            // 
            this.txtVPass.Location = new System.Drawing.Point(12, 192);
            this.txtVPass.Name = "txtVPass";
            this.txtVPass.Size = new System.Drawing.Size(255, 22);
            this.txtVPass.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 236);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 46);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 294);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtVPass);
            this.Controls.Add(this.lblVPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddTeacher";
            this.Text = "Adicionar Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblVPass;
        private System.Windows.Forms.TextBox txtVPass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}