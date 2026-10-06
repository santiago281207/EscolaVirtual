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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.formLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pPassword = new System.Windows.Forms.Panel();
            this.pCorPassword = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pbLogoInete = new System.Windows.Forms.PictureBox();
            this.lbl_VirtualSchool = new System.Windows.Forms.Label();
            this.formLogin.SuspendLayout();
            this.pPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.pUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInete)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cadeado-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-pessoa-do-sexo-masculino-24.png");
            // 
            // formLogin
            // 
            this.formLogin.BackColor = System.Drawing.Color.White;
            this.formLogin.Controls.Add(this.btnLogin);
            this.formLogin.Controls.Add(this.pPassword);
            this.formLogin.Controls.Add(this.lblPassword);
            this.formLogin.Controls.Add(this.pUsername);
            this.formLogin.Controls.Add(this.lblLogin);
            this.formLogin.Controls.Add(this.pbLogoInete);
            this.formLogin.Controls.Add(this.lbl_VirtualSchool);
            this.formLogin.Location = new System.Drawing.Point(351, -1);
            this.formLogin.Margin = new System.Windows.Forms.Padding(4);
            this.formLogin.Name = "formLogin";
            this.formLogin.Size = new System.Drawing.Size(575, 802);
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
            this.btnLogin.Location = new System.Drawing.Point(69, 593);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(439, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pPassword
            // 
            this.pPassword.Controls.Add(this.pCorPassword);
            this.pPassword.Controls.Add(this.panel7);
            this.pPassword.Controls.Add(this.pbPassword);
            this.pPassword.Controls.Add(this.txtPassword);
            this.pPassword.Location = new System.Drawing.Point(69, 401);
            this.pPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(439, 44);
            this.pPassword.TabIndex = 5;
            // 
            // pCorPassword
            // 
            this.pCorPassword.BackColor = System.Drawing.Color.Green;
            this.pCorPassword.Location = new System.Drawing.Point(0, 38);
            this.pCorPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pCorPassword.Name = "pCorPassword";
            this.pCorPassword.Size = new System.Drawing.Size(439, 5);
            this.pCorPassword.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(439, 12);
            this.panel7.TabIndex = 4;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::EscolaVirtual.Properties.Resources.icons8_cadeado_50;
            this.pbPassword.Location = new System.Drawing.Point(401, 6);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 31);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(3, 12);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(389, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(69, 375);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.pCorUsername);
            this.pUsername.Controls.Add(this.panel3);
            this.pUsername.Controls.Add(this.pbUsername);
            this.pUsername.Controls.Add(this.txtLogin);
            this.pUsername.Location = new System.Drawing.Point(69, 315);
            this.pUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(439, 44);
            this.pUsername.TabIndex = 3;
            // 
            // pCorUsername
            // 
            this.pCorUsername.BackColor = System.Drawing.Color.Green;
            this.pCorUsername.Location = new System.Drawing.Point(0, 38);
            this.pCorUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pCorUsername.Name = "pCorUsername";
            this.pCorUsername.Size = new System.Drawing.Size(439, 5);
            this.pCorUsername.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 12);
            this.panel3.TabIndex = 4;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbUsername.Location = new System.Drawing.Point(401, 6);
            this.pbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 31);
            this.pbUsername.TabIndex = 4;
            this.pbUsername.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(3, 12);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 4;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(389, 22);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(69, 289);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(57, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // pbLogoInete
            // 
            this.pbLogoInete.Image = global::EscolaVirtual.Properties.Resources.icon;
            this.pbLogoInete.Location = new System.Drawing.Point(125, 73);
            this.pbLogoInete.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoInete.Name = "pbLogoInete";
            this.pbLogoInete.Size = new System.Drawing.Size(101, 94);
            this.pbLogoInete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoInete.TabIndex = 0;
            this.pbLogoInete.TabStop = false;
            // 
            // lbl_VirtualSchool
            // 
            this.lbl_VirtualSchool.AutoSize = true;
            this.lbl_VirtualSchool.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VirtualSchool.Location = new System.Drawing.Point(223, 96);
            this.lbl_VirtualSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VirtualSchool.Name = "lbl_VirtualSchool";
            this.lbl_VirtualSchool.Size = new System.Drawing.Size(234, 46);
            this.lbl_VirtualSchool.TabIndex = 1;
            this.lbl_VirtualSchool.Text = "Virtual School";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.formLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel formLogin;
        private System.Windows.Forms.PictureBox pbLogoInete;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lbl_VirtualSchool;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.Panel pCorPassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pCorUsername;
        private System.Windows.Forms.Button btnLogin;
    }
}

