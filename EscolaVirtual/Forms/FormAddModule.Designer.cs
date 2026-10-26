namespace EscolaVirtual
{
    partial class FormAddModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddModule));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pColorName = new System.Windows.Forms.Panel();
            this.pModuleSubject = new System.Windows.Forms.Panel();
            this.cbModuleSubject = new System.Windows.Forms.ComboBox();
            this.pColorSubModule = new System.Windows.Forms.Panel();
            this.pbSubModule = new System.Windows.Forms.PictureBox();
            this.lblModuleSubject = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Panel();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.lblNameModule = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.pnlCreate.SuspendLayout();
            this.pModuleSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubModule)).BeginInit();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.White;
            this.pnlCreate.Controls.Add(this.pColorName);
            this.pnlCreate.Controls.Add(this.pModuleSubject);
            this.pnlCreate.Controls.Add(this.lblModuleSubject);
            this.pnlCreate.Controls.Add(this.pName);
            this.pnlCreate.Controls.Add(this.lblNameModule);
            this.pnlCreate.Controls.Add(this.btnBack);
            this.pnlCreate.Controls.Add(this.btnCreateModule);
            this.pnlCreate.Location = new System.Drawing.Point(87, 0);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(392, 275);
            this.pnlCreate.TabIndex = 8;
            // 
            // pColorName
            // 
            this.pColorName.BackColor = System.Drawing.Color.Green;
            this.pColorName.Location = new System.Drawing.Point(25, 165);
            this.pColorName.Margin = new System.Windows.Forms.Padding(2);
            this.pColorName.Name = "pColorName";
            this.pColorName.Size = new System.Drawing.Size(329, 4);
            this.pColorName.TabIndex = 9;
            // 
            // pModuleSubject
            // 
            this.pModuleSubject.Controls.Add(this.cbModuleSubject);
            this.pModuleSubject.Controls.Add(this.pColorSubModule);
            this.pModuleSubject.Controls.Add(this.pbSubModule);
            this.pModuleSubject.Location = new System.Drawing.Point(27, 63);
            this.pModuleSubject.Margin = new System.Windows.Forms.Padding(2);
            this.pModuleSubject.Name = "pModuleSubject";
            this.pModuleSubject.Size = new System.Drawing.Size(329, 36);
            this.pModuleSubject.TabIndex = 57;
            // 
            // cbModuleSubject
            // 
            this.cbModuleSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModuleSubject.FormattingEnabled = true;
            this.cbModuleSubject.Location = new System.Drawing.Point(4, 6);
            this.cbModuleSubject.Name = "cbModuleSubject";
            this.cbModuleSubject.Size = new System.Drawing.Size(291, 21);
            this.cbModuleSubject.TabIndex = 10;
            this.cbModuleSubject.SelectedIndexChanged += new System.EventHandler(this.cbModuleSubject_SelectedIndexChanged);
            // 
            // pColorSubModule
            // 
            this.pColorSubModule.BackColor = System.Drawing.Color.Green;
            this.pColorSubModule.Location = new System.Drawing.Point(0, 32);
            this.pColorSubModule.Margin = new System.Windows.Forms.Padding(2);
            this.pColorSubModule.Name = "pColorSubModule";
            this.pColorSubModule.Size = new System.Drawing.Size(329, 4);
            this.pColorSubModule.TabIndex = 9;
            // 
            // pbSubModule
            // 
            this.pbSubModule.Image = global::EscolaVirtual.Properties.Resources.google_classroom;
            this.pbSubModule.Location = new System.Drawing.Point(299, 2);
            this.pbSubModule.Name = "pbSubModule";
            this.pbSubModule.Size = new System.Drawing.Size(24, 25);
            this.pbSubModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubModule.TabIndex = 5;
            this.pbSubModule.TabStop = false;
            // 
            // lblModuleSubject
            // 
            this.lblModuleSubject.AutoSize = true;
            this.lblModuleSubject.Location = new System.Drawing.Point(27, 47);
            this.lblModuleSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleSubject.Name = "lblModuleSubject";
            this.lblModuleSubject.Size = new System.Drawing.Size(105, 13);
            this.lblModuleSubject.TabIndex = 56;
            this.lblModuleSubject.Text = "Disciplina do Módulo";
            // 
            // pName
            // 
            this.pName.Controls.Add(this.pbName);
            this.pName.Controls.Add(this.txtModuleName);
            this.pName.Location = new System.Drawing.Point(27, 133);
            this.pName.Margin = new System.Windows.Forms.Padding(2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(329, 36);
            this.pName.TabIndex = 55;
            // 
            // pbName
            // 
            this.pbName.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbName.Location = new System.Drawing.Point(299, 2);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(24, 25);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbName.TabIndex = 5;
            this.pbName.TabStop = false;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(2, 10);
            this.txtModuleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtModuleName.MaxLength = 30;
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(293, 20);
            this.txtModuleName.TabIndex = 2;
            this.txtModuleName.TextChanged += new System.EventHandler(this.txtModuleName_TextChanged);
            // 
            // lblNameModule
            // 
            this.lblNameModule.AutoSize = true;
            this.lblNameModule.Location = new System.Drawing.Point(27, 118);
            this.lblNameModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameModule.Name = "lblNameModule";
            this.lblNameModule.Size = new System.Drawing.Size(88, 13);
            this.lblNameModule.TabIndex = 54;
            this.lblNameModule.Text = "Nome do Módulo";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(66, 198);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Sair";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateModule
            // 
            this.btnCreateModule.BackColor = System.Drawing.Color.Green;
            this.btnCreateModule.Enabled = false;
            this.btnCreateModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateModule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateModule.Location = new System.Drawing.Point(223, 198);
            this.btnCreateModule.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(104, 37);
            this.btnCreateModule.TabIndex = 10;
            this.btnCreateModule.Text = "Adicionar";
            this.btnCreateModule.UseVisualStyleBackColor = false;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // FormAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(562, 276);
            this.Controls.Add(this.pnlCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddModule";
            this.Load += new System.EventHandler(this.FormAddModule_Load);
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pModuleSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubModule)).EndInit();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Panel pColorName;
        private System.Windows.Forms.Panel pModuleSubject;
        private System.Windows.Forms.ComboBox cbModuleSubject;
        private System.Windows.Forms.Panel pColorSubModule;
        private System.Windows.Forms.PictureBox pbSubModule;
        private System.Windows.Forms.Label lblModuleSubject;
        private System.Windows.Forms.Panel pName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label lblNameModule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateModule;
    }
}