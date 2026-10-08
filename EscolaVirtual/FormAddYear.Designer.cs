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
            this.pCorClasses = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pClasses = new System.Windows.Forms.Panel();
            this.lvwClasses = new System.Windows.Forms.ListView();
            this.pbClasses = new System.Windows.Forms.PictureBox();
            this.lblClasses = new System.Windows.Forms.Label();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.pbYearName = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.formLogin.SuspendLayout();
            this.pClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClasses)).BeginInit();
            this.pUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYearName)).BeginInit();
            this.SuspendLayout();
            // 
            // formLogin
            // 
            this.formLogin.BackColor = System.Drawing.Color.White;
            this.formLogin.Controls.Add(this.btnExit);
            this.formLogin.Controls.Add(this.pCorClasses);
            this.formLogin.Controls.Add(this.btnCreate);
            this.formLogin.Controls.Add(this.pClasses);
            this.formLogin.Controls.Add(this.lblClasses);
            this.formLogin.Controls.Add(this.pUsername);
            this.formLogin.Controls.Add(this.lblName);
            this.formLogin.Location = new System.Drawing.Point(263, -1);
            this.formLogin.Name = "formLogin";
            this.formLogin.Size = new System.Drawing.Size(431, 652);
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
            this.btnExit.Location = new System.Drawing.Point(48, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(329, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pCorClasses
            // 
            this.pCorClasses.BackColor = System.Drawing.Color.Green;
            this.pCorClasses.Location = new System.Drawing.Point(44, 464);
            this.pCorClasses.Name = "pCorClasses";
            this.pCorClasses.Size = new System.Drawing.Size(329, 4);
            this.pCorClasses.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreate.Location = new System.Drawing.Point(48, 521);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(329, 37);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // pClasses
            // 
            this.pClasses.Controls.Add(this.lvwClasses);
            this.pClasses.Controls.Add(this.pbClasses);
            this.pClasses.Location = new System.Drawing.Point(44, 129);
            this.pClasses.Name = "pClasses";
            this.pClasses.Size = new System.Drawing.Size(329, 339);
            this.pClasses.TabIndex = 5;
            // 
            // lvwClasses
            // 
            this.lvwClasses.FullRowSelect = true;
            this.lvwClasses.GridLines = true;
            this.lvwClasses.HideSelection = false;
            this.lvwClasses.Location = new System.Drawing.Point(4, 6);
            this.lvwClasses.Name = "lvwClasses";
            this.lvwClasses.OwnerDraw = true;
            this.lvwClasses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwClasses.Size = new System.Drawing.Size(291, 323);
            this.lvwClasses.TabIndex = 5;
            this.lvwClasses.UseCompatibleStateImageBehavior = false;
            this.lvwClasses.View = System.Windows.Forms.View.Details;
            // 
            // pbClasses
            // 
            this.pbClasses.Image = global::EscolaVirtual.Properties.Resources.google_classroom;
            this.pbClasses.Location = new System.Drawing.Point(301, 155);
            this.pbClasses.Name = "pbClasses";
            this.pbClasses.Size = new System.Drawing.Size(24, 25);
            this.pbClasses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClasses.TabIndex = 4;
            this.pbClasses.TabStop = false;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(44, 106);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(57, 20);
            this.lblClasses.TabIndex = 4;
            this.lblClasses.Text = "Turmas";
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.pCorUsername);
            this.pUsername.Controls.Add(this.pbYearName);
            this.pUsername.Controls.Add(this.txt);
            this.pUsername.Location = new System.Drawing.Point(44, 51);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(329, 36);
            this.pUsername.TabIndex = 3;
            // 
            // pCorUsername
            // 
            this.pCorUsername.BackColor = System.Drawing.Color.Green;
            this.pCorUsername.Location = new System.Drawing.Point(0, 31);
            this.pCorUsername.Name = "pCorUsername";
            this.pCorUsername.Size = new System.Drawing.Size(329, 4);
            this.pCorUsername.TabIndex = 4;
            // 
            // pbYearName
            // 
            this.pbYearName.Image = global::EscolaVirtual.Properties.Resources.icone_du_calendrier_des_evenements_vert;
            this.pbYearName.Location = new System.Drawing.Point(301, 5);
            this.pbYearName.Name = "pbYearName";
            this.pbYearName.Size = new System.Drawing.Size(24, 25);
            this.pbYearName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYearName.TabIndex = 4;
            this.pbYearName.TabStop = false;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(4, 10);
            this.txt.MaxLength = 4;
            this.txt.Name = "txt";
            this.txt.PasswordChar = '*';
            this.txt.Size = new System.Drawing.Size(291, 20);
            this.txt.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do Ano";
            // 
            // FormAddYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.formLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddYear";
            this.formLogin.ResumeLayout(false);
            this.formLogin.PerformLayout();
            this.pClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClasses)).EndInit();
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
        private System.Windows.Forms.Panel pCorClasses;
        private System.Windows.Forms.Panel pClasses;
        private System.Windows.Forms.ListView lvwClasses;
        private System.Windows.Forms.PictureBox pbClasses;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblName;
    }
}