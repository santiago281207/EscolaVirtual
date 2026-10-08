namespace EscolaVirtual.Forms
{
    partial class FormAdicionarAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pColorName = new System.Windows.Forms.Panel();
            this.pNIF = new System.Windows.Forms.Panel();
            this.pColorNIF = new System.Windows.Forms.Panel();
            this.pbNIF = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.pClass = new System.Windows.Forms.Panel();
            this.pColorClass = new System.Windows.Forms.Panel();
            this.pbClass = new System.Windows.Forms.PictureBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.pbLogoInete = new System.Windows.Forms.PictureBox();
            this.lbl_VirtualSchool = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.pNIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).BeginInit();
            this.pClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogoInete);
            this.panel1.Controls.Add(this.lbl_VirtualSchool);
            this.panel1.Controls.Add(this.pClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.pNIF);
            this.panel1.Controls.Add(this.lblNIF);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCreateStudent);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(351, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 802);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 22);
            this.textBox3.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 244);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.Green;
            this.btnCreateStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateStudent.Location = new System.Drawing.Point(69, 574);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(439, 44);
            this.btnCreateStudent.TabIndex = 6;
            this.btnCreateStudent.Text = "Criar Aluno";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(69, 680);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(439, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pName
            // 
            this.pName.Controls.Add(this.pColorName);
            this.pName.Controls.Add(this.pbUsername);
            this.pName.Controls.Add(this.textBox3);
            this.pName.Location = new System.Drawing.Point(66, 263);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(439, 44);
            this.pName.TabIndex = 8;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbUsername.Location = new System.Drawing.Point(399, 3);
            this.pbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 31);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 5;
            this.pbUsername.TabStop = false;
            // 
            // pColorName
            // 
            this.pColorName.BackColor = System.Drawing.Color.Green;
            this.pColorName.Location = new System.Drawing.Point(0, 36);
            this.pColorName.Name = "pColorName";
            this.pColorName.Size = new System.Drawing.Size(439, 5);
            this.pColorName.TabIndex = 9;
            // 
            // pNIF
            // 
            this.pNIF.Controls.Add(this.pColorNIF);
            this.pNIF.Controls.Add(this.pbNIF);
            this.pNIF.Controls.Add(this.textBox4);
            this.pNIF.Location = new System.Drawing.Point(66, 337);
            this.pNIF.Name = "pNIF";
            this.pNIF.Size = new System.Drawing.Size(439, 44);
            this.pNIF.TabIndex = 11;
            // 
            // pColorNIF
            // 
            this.pColorNIF.BackColor = System.Drawing.Color.Green;
            this.pColorNIF.Location = new System.Drawing.Point(0, 36);
            this.pColorNIF.Name = "pColorNIF";
            this.pColorNIF.Size = new System.Drawing.Size(439, 5);
            this.pColorNIF.TabIndex = 9;
            // 
            // pbNIF
            // 
            this.pbNIF.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbNIF.Location = new System.Drawing.Point(399, 3);
            this.pbNIF.Margin = new System.Windows.Forms.Padding(4);
            this.pbNIF.Name = "pbNIF";
            this.pbNIF.Size = new System.Drawing.Size(32, 31);
            this.pbNIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNIF.TabIndex = 5;
            this.pbNIF.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(389, 22);
            this.textBox4.TabIndex = 2;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(66, 318);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(28, 16);
            this.lblNIF.TabIndex = 10;
            this.lblNIF.Text = "NIF";
            // 
            // pClass
            // 
            this.pClass.Controls.Add(this.cbClass);
            this.pClass.Controls.Add(this.pColorClass);
            this.pClass.Controls.Add(this.pbClass);
            this.pClass.Location = new System.Drawing.Point(66, 412);
            this.pClass.Name = "pClass";
            this.pClass.Size = new System.Drawing.Size(439, 44);
            this.pClass.TabIndex = 11;
            // 
            // pColorClass
            // 
            this.pColorClass.BackColor = System.Drawing.Color.Green;
            this.pColorClass.Location = new System.Drawing.Point(0, 36);
            this.pColorClass.Name = "pColorClass";
            this.pColorClass.Size = new System.Drawing.Size(439, 5);
            this.pColorClass.TabIndex = 9;
            // 
            // pbClass
            // 
            this.pbClass.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbClass.Location = new System.Drawing.Point(399, 3);
            this.pbClass.Margin = new System.Windows.Forms.Padding(4);
            this.pbClass.Name = "pbClass";
            this.pbClass.Size = new System.Drawing.Size(32, 31);
            this.pbClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClass.TabIndex = 5;
            this.pbClass.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(66, 393);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Turma";
            // 
            // pbLogoInete
            // 
            this.pbLogoInete.Image = global::EscolaVirtual.Properties.Resources.icon;
            this.pbLogoInete.Location = new System.Drawing.Point(124, 59);
            this.pbLogoInete.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoInete.Name = "pbLogoInete";
            this.pbLogoInete.Size = new System.Drawing.Size(101, 94);
            this.pbLogoInete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoInete.TabIndex = 12;
            this.pbLogoInete.TabStop = false;
            // 
            // lbl_VirtualSchool
            // 
            this.lbl_VirtualSchool.AutoSize = true;
            this.lbl_VirtualSchool.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VirtualSchool.Location = new System.Drawing.Point(222, 82);
            this.lbl_VirtualSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VirtualSchool.Name = "lbl_VirtualSchool";
            this.lbl_VirtualSchool.Size = new System.Drawing.Size(234, 46);
            this.lbl_VirtualSchool.TabIndex = 13;
            this.lbl_VirtualSchool.Text = "Virtual School";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(3, 12);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(389, 24);
            this.cbClass.TabIndex = 10;
            // 
            // FormAdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdicionarAluno";
            this.Text = "FormAdicionarAluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.pNIF.ResumeLayout(false);
            this.pNIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).EndInit();
            this.pClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pName;
        private System.Windows.Forms.Panel pColorName;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Panel pClass;
        private System.Windows.Forms.Panel pColorClass;
        private System.Windows.Forms.PictureBox pbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Panel pNIF;
        private System.Windows.Forms.Panel pColorNIF;
        private System.Windows.Forms.PictureBox pbNIF;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.PictureBox pbLogoInete;
        private System.Windows.Forms.Label lbl_VirtualSchool;
        private System.Windows.Forms.ComboBox cbClass;
    }
}