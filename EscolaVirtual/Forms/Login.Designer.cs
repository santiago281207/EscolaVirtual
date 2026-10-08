namespace EscolaVirtual
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.formLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pPassword = new System.Windows.Forms.Panel();
            this.pCorPassword = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lbl_VirtualSchool = new System.Windows.Forms.Label();
            this.pbLogoInete = new System.Windows.Forms.PictureBox();
            this.formLogin.SuspendLayout();
            this.pPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.pUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInete)).BeginInit();
            this.SuspendLayout();
            // 
            // ilImages
            // 
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "icon.png");
            this.ilImages.Images.SetKeyName(1, "icons8-cadeado-50.png");
            this.ilImages.Images.SetKeyName(2, "icons8-pessoa-do-sexo-masculino-24.png");
            // 
            // formLogin
            // 
            this.formLogin.BackColor = System.Drawing.Color.White;
            this.formLogin.Controls.Add(this.pbLogoInete);
            this.formLogin.Controls.Add(this.btnLogin);
            this.formLogin.Controls.Add(this.pPassword);
            this.formLogin.Controls.Add(this.lblPassword);
            this.formLogin.Controls.Add(this.pUsername);
            this.formLogin.Controls.Add(this.lblLogin);
            this.formLogin.Controls.Add(this.lbl_VirtualSchool);
            this.formLogin.Location = new System.Drawing.Point(263, -1);
            this.formLogin.Name = "formLogin";
            this.formLogin.Size = new System.Drawing.Size(431, 652);
            this.formLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Location = new System.Drawing.Point(52, 482);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(329, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pPassword
            // 
            this.pPassword.Controls.Add(this.pCorPassword);
            this.pPassword.Controls.Add(this.pbPassword);
            this.pPassword.Controls.Add(this.txtPassword);
            this.pPassword.Location = new System.Drawing.Point(52, 326);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(329, 36);
            this.pPassword.TabIndex = 5;
            // 
            // pCorPassword
            // 
            this.pCorPassword.BackColor = System.Drawing.Color.Green;
            this.pCorPassword.Location = new System.Drawing.Point(0, 31);
            this.pCorPassword.Name = "pCorPassword";
            this.pCorPassword.Size = new System.Drawing.Size(329, 4);
            this.pCorPassword.TabIndex = 4;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::EscolaVirtual.Properties.Resources.icons8_cadeado_50;
            this.pbPassword.Location = new System.Drawing.Point(301, 5);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(24, 25);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(2, 10);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(52, 305);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.pCorUsername);
            this.pUsername.Controls.Add(this.pbUsername);
            this.pUsername.Controls.Add(this.txtLogin);
            this.pUsername.Location = new System.Drawing.Point(52, 256);
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
            // pbUsername
            // 
            this.pbUsername.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbUsername.Location = new System.Drawing.Point(301, 5);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(24, 25);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 4;
            this.pbUsername.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(2, 10);
            this.txtLogin.MaxLength = 4;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(293, 20);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(52, 235);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lbl_VirtualSchool
            // 
            this.lbl_VirtualSchool.AutoSize = true;
            this.lbl_VirtualSchool.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VirtualSchool.Location = new System.Drawing.Point(174, 82);
            this.lbl_VirtualSchool.Name = "lbl_VirtualSchool";
            this.lbl_VirtualSchool.Size = new System.Drawing.Size(189, 37);
            this.lbl_VirtualSchool.TabIndex = 1;
            this.lbl_VirtualSchool.Text = "Virtual School";
            // 
            // pbLogoInete
            // 
            this.pbLogoInete.Image = global::EscolaVirtual.Properties.Resources.icon;
            this.pbLogoInete.Location = new System.Drawing.Point(94, 62);
            this.pbLogoInete.Name = "pbLogoInete";
            this.pbLogoInete.Size = new System.Drawing.Size(85, 79);
            this.pbLogoInete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoInete.TabIndex = 7;
            this.pbLogoInete.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.formLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.formLogin.ResumeLayout(false);
            this.formLogin.PerformLayout();
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.pUsername.ResumeLayout(false);
            this.pUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.Panel formLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lbl_VirtualSchool;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.Panel pCorPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pCorUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLogoInete;
    }
}

