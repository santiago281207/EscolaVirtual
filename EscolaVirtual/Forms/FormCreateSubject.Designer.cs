namespace EscolaVirtual.Forms
{
    partial class FormCreateSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateSubject));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pColorName = new System.Windows.Forms.Panel();
            this.pYear = new System.Windows.Forms.Panel();
            this.cbClassYear = new System.Windows.Forms.ComboBox();
            this.pColorYear = new System.Windows.Forms.Panel();
            this.pbYear = new System.Windows.Forms.PictureBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.pnlCreate.SuspendLayout();
            this.pYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYear)).BeginInit();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.White;
            this.pnlCreate.Controls.Add(this.pColorName);
            this.pnlCreate.Controls.Add(this.pYear);
            this.pnlCreate.Controls.Add(this.lblYear);
            this.pnlCreate.Controls.Add(this.pName);
            this.pnlCreate.Controls.Add(this.lblName);
            this.pnlCreate.Controls.Add(this.btnBack);
            this.pnlCreate.Controls.Add(this.btnCreateSubject);
            this.pnlCreate.Location = new System.Drawing.Point(87, 0);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(392, 275);
            this.pnlCreate.TabIndex = 7;
            // 
            // pColorName
            // 
            this.pColorName.BackColor = System.Drawing.Color.Green;
            this.pColorName.Location = new System.Drawing.Point(30, 83);
            this.pColorName.Margin = new System.Windows.Forms.Padding(2);
            this.pColorName.Name = "pColorName";
            this.pColorName.Size = new System.Drawing.Size(329, 4);
            this.pColorName.TabIndex = 9;
            // 
            // pYear
            // 
            this.pYear.Controls.Add(this.cbClassYear);
            this.pYear.Controls.Add(this.pColorYear);
            this.pYear.Controls.Add(this.pbYear);
            this.pYear.Location = new System.Drawing.Point(32, 126);
            this.pYear.Margin = new System.Windows.Forms.Padding(2);
            this.pYear.Name = "pYear";
            this.pYear.Size = new System.Drawing.Size(329, 36);
            this.pYear.TabIndex = 57;
            // 
            // cbClassYear
            // 
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Location = new System.Drawing.Point(4, 6);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(291, 21);
            this.cbClassYear.TabIndex = 10;
            this.cbClassYear.SelectedIndexChanged += new System.EventHandler(this.cbClassYear_SelectedIndexChanged);
            // 
            // pColorYear
            // 
            this.pColorYear.BackColor = System.Drawing.Color.Green;
            this.pColorYear.Location = new System.Drawing.Point(0, 32);
            this.pColorYear.Margin = new System.Windows.Forms.Padding(2);
            this.pColorYear.Name = "pColorYear";
            this.pColorYear.Size = new System.Drawing.Size(329, 4);
            this.pColorYear.TabIndex = 9;
            // 
            // pbYear
            // 
            this.pbYear.Image = global::EscolaVirtual.Properties.Resources.icone_du_calendrier_des_evenements_vert;
            this.pbYear.Location = new System.Drawing.Point(299, 2);
            this.pbYear.Name = "pbYear";
            this.pbYear.Size = new System.Drawing.Size(24, 25);
            this.pbYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYear.TabIndex = 5;
            this.pbYear.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(32, 110);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(89, 13);
            this.lblYear.TabIndex = 56;
            this.lblYear.Text = "Ano da Disciplina";
            // 
            // pName
            // 
            this.pName.Controls.Add(this.pbUsername);
            this.pName.Controls.Add(this.txtSubjectName);
            this.pName.Location = new System.Drawing.Point(32, 51);
            this.pName.Margin = new System.Windows.Forms.Padding(2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(329, 36);
            this.pName.TabIndex = 55;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbUsername.Location = new System.Drawing.Point(299, 2);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(24, 25);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 5;
            this.pbUsername.TabStop = false;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(2, 10);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectName.MaxLength = 30;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(293, 20);
            this.txtSubjectName.TabIndex = 2;
            this.txtSubjectName.TextChanged += new System.EventHandler(this.txtSubjectName_TextChanged);
            this.txtSubjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubjectName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 13);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Nome da Disciplina";
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
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.Color.Green;
            this.btnCreateSubject.Enabled = false;
            this.btnCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateSubject.Location = new System.Drawing.Point(223, 198);
            this.btnCreateSubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(104, 37);
            this.btnCreateSubject.TabIndex = 10;
            this.btnCreateSubject.Text = "Adicionar";
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // FormCreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(562, 276);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCreateSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Disciplina";
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbYear)).EndInit();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pColorName;
        private System.Windows.Forms.Panel pYear;
        private System.Windows.Forms.Panel pColorYear;
        private System.Windows.Forms.PictureBox pbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel pName;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbClassYear;
    }
}