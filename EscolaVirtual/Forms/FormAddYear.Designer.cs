namespace EscolaVirtual
{
    partial class FormAddYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddYear));
            this.formLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.pbYearName = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.formLogin.SuspendLayout();
            this.pUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYearName)).BeginInit();
            this.SuspendLayout();
            // 
            // formLogin
            // 
            this.formLogin.BackColor = System.Drawing.Color.White;
            this.formLogin.Controls.Add(this.btnExit);
            this.formLogin.Controls.Add(this.btnCreate);
            this.formLogin.Controls.Add(this.pUsername);
            this.formLogin.Controls.Add(this.lblName);
            this.formLogin.Location = new System.Drawing.Point(124, 0);
            this.formLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.formLogin.Name = "formLogin";
            this.formLogin.Size = new System.Drawing.Size(575, 298);
            this.formLogin.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.Enabled = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Location = new System.Drawing.Point(59, 198);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(439, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreate.Location = new System.Drawing.Point(59, 145);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(439, 46);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.pCorUsername);
            this.pUsername.Controls.Add(this.pbYearName);
            this.pUsername.Controls.Add(this.txt);
            this.pUsername.Location = new System.Drawing.Point(59, 63);
            this.pUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(439, 44);
            this.pUsername.TabIndex = 3;
            // 
            // pCorUsername
            // 
            this.pCorUsername.BackColor = System.Drawing.Color.Green;
            this.pCorUsername.Location = new System.Drawing.Point(0, 38);
            this.pCorUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCorUsername.Name = "pCorUsername";
            this.pCorUsername.Size = new System.Drawing.Size(439, 5);
            this.pCorUsername.TabIndex = 4;
            // 
            // pbYearName
            // 
            this.pbYearName.Image = global::EscolaVirtual.Properties.Resources.icone_du_calendrier_des_evenements_vert;
            this.pbYearName.Location = new System.Drawing.Point(401, 6);
            this.pbYearName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbYearName.Name = "pbYearName";
            this.pbYearName.Size = new System.Drawing.Size(32, 31);
            this.pbYearName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYearName.TabIndex = 4;
            this.pbYearName.TabStop = false;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(5, 12);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt.MaxLength = 4;
            this.txt.Name = "txt";
            this.txt.PasswordChar = '*';
            this.txt.Size = new System.Drawing.Size(387, 22);
            this.txt.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do Ano";
            // 
            // FormAddYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(823, 299);
            this.Controls.Add(this.formLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddYear";
            this.Load += new System.EventHandler(this.FormAddYear_Load);
            this.formLogin.ResumeLayout(false);
            this.formLogin.PerformLayout();
            this.pUsername.ResumeLayout(false);
            this.pUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYearName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.Panel pCorUsername;
        private System.Windows.Forms.PictureBox pbYearName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblName;
    }
}