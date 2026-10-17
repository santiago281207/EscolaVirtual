namespace EscolaVirtual.Forms
{
    partial class FormAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pClass = new System.Windows.Forms.Panel();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.pColorClass = new System.Windows.Forms.Panel();
            this.pbClass = new System.Windows.Forms.PictureBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.pNIF = new System.Windows.Forms.Panel();
            this.pColorNIF = new System.Windows.Forms.Panel();
            this.pbNIF = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Panel();
            this.pColorName = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlCreate.SuspendLayout();
            this.pClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).BeginInit();
            this.pNIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).BeginInit();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.White;
            this.pnlCreate.Controls.Add(this.pClass);
            this.pnlCreate.Controls.Add(this.lblClass);
            this.pnlCreate.Controls.Add(this.pNIF);
            this.pnlCreate.Controls.Add(this.lblNIF);
            this.pnlCreate.Controls.Add(this.pName);
            this.pnlCreate.Controls.Add(this.btnExit);
            this.pnlCreate.Controls.Add(this.btnCreateStudent);
            this.pnlCreate.Controls.Add(this.lblName);
            this.pnlCreate.Location = new System.Drawing.Point(154, 1);
            this.pnlCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(431, 305);
            this.pnlCreate.TabIndex = 0;
            // 
            // pClass
            // 
            this.pClass.Controls.Add(this.cbClass);
            this.pClass.Controls.Add(this.pColorClass);
            this.pClass.Controls.Add(this.pbClass);
            this.pClass.Location = new System.Drawing.Point(50, 170);
            this.pClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pClass.Name = "pClass";
            this.pClass.Size = new System.Drawing.Size(329, 36);
            this.pClass.TabIndex = 11;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(2, 10);
            this.cbClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(293, 21);
            this.cbClass.TabIndex = 10;
            // 
            // pColorClass
            // 
            this.pColorClass.BackColor = System.Drawing.Color.Green;
            this.pColorClass.Location = new System.Drawing.Point(0, 29);
            this.pColorClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pColorClass.Name = "pColorClass";
            this.pColorClass.Size = new System.Drawing.Size(329, 4);
            this.pColorClass.TabIndex = 9;
            // 
            // pbClass
            // 
            this.pbClass.Image = global::EscolaVirtual.Properties.Resources.google_classroom;
            this.pbClass.Location = new System.Drawing.Point(299, 2);
            this.pbClass.Name = "pbClass";
            this.pbClass.Size = new System.Drawing.Size(24, 25);
            this.pbClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClass.TabIndex = 5;
            this.pbClass.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(50, 154);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 13);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Turma";
            // 
            // pNIF
            // 
            this.pNIF.Controls.Add(this.pColorNIF);
            this.pNIF.Controls.Add(this.pbNIF);
            this.pNIF.Controls.Add(this.textBox4);
            this.pNIF.Location = new System.Drawing.Point(49, 109);
            this.pNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pNIF.Name = "pNIF";
            this.pNIF.Size = new System.Drawing.Size(329, 36);
            this.pNIF.TabIndex = 11;
            // 
            // pColorNIF
            // 
            this.pColorNIF.BackColor = System.Drawing.Color.Green;
            this.pColorNIF.Location = new System.Drawing.Point(0, 29);
            this.pColorNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pColorNIF.Name = "pColorNIF";
            this.pColorNIF.Size = new System.Drawing.Size(329, 4);
            this.pColorNIF.TabIndex = 9;
            // 
            // pbNIF
            // 
            this.pbNIF.Image = global::EscolaVirtual.Properties.Resources._245204;
            this.pbNIF.Location = new System.Drawing.Point(299, 2);
            this.pbNIF.Name = "pbNIF";
            this.pbNIF.Size = new System.Drawing.Size(24, 25);
            this.pbNIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNIF.TabIndex = 5;
            this.pbNIF.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.MaxLength = 9;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(293, 20);
            this.textBox4.TabIndex = 2;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(49, 93);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(24, 13);
            this.lblNIF.TabIndex = 10;
            this.lblNIF.Text = "NIF";
            // 
            // pName
            // 
            this.pName.Controls.Add(this.pColorName);
            this.pName.Controls.Add(this.pbUsername);
            this.pName.Controls.Add(this.textBox3);
            this.pName.Location = new System.Drawing.Point(50, 47);
            this.pName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(329, 36);
            this.pName.TabIndex = 8;
            // 
            // pColorName
            // 
            this.pColorName.BackColor = System.Drawing.Color.Green;
            this.pColorName.Location = new System.Drawing.Point(0, 29);
            this.pColorName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pColorName.Name = "pColorName";
            this.pColorName.Size = new System.Drawing.Size(329, 4);
            this.pColorName.TabIndex = 9;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(49, 223);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.Green;
            this.btnCreateStudent.Enabled = false;
            this.btnCreateStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateStudent.Location = new System.Drawing.Point(214, 223);
            this.btnCreateStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(165, 36);
            this.btnCreateStudent.TabIndex = 6;
            this.btnCreateStudent.Text = "Criar Aluno";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(752, 305);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAddStudent";
            this.Text = "FormAdicionarAluno";
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).EndInit();
            this.pNIF.ResumeLayout(false);
            this.pNIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).EndInit();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreate;
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
        private System.Windows.Forms.ComboBox cbClass;
    }
}