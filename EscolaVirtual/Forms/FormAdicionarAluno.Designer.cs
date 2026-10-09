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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarAluno));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pClass = new System.Windows.Forms.Panel();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.pColorClass = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.pNIF = new System.Windows.Forms.Panel();
            this.pColorNIF = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Panel();
            this.pColorName = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pbClass = new System.Windows.Forms.PictureBox();
            this.pbNIF = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pnlCreate.SuspendLayout();
            this.pClass.SuspendLayout();
            this.pNIF.SuspendLayout();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).BeginInit();
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
            this.pnlCreate.Location = new System.Drawing.Point(206, 1);
            this.pnlCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(575, 375);
            this.pnlCreate.TabIndex = 0;
            // 
            // pClass
            // 
            this.pClass.Controls.Add(this.cbClass);
            this.pClass.Controls.Add(this.pColorClass);
            this.pClass.Controls.Add(this.pbClass);
            this.pClass.Location = new System.Drawing.Point(66, 209);
            this.pClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pClass.Name = "pClass";
            this.pClass.Size = new System.Drawing.Size(439, 44);
            this.pClass.TabIndex = 11;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(3, 12);
            this.cbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(389, 24);
            this.cbClass.TabIndex = 10;
            // 
            // pColorClass
            // 
            this.pColorClass.BackColor = System.Drawing.Color.Green;
            this.pColorClass.Location = new System.Drawing.Point(0, 36);
            this.pColorClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pColorClass.Name = "pColorClass";
            this.pColorClass.Size = new System.Drawing.Size(439, 5);
            this.pColorClass.TabIndex = 9;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(66, 190);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Turma";
            // 
            // pNIF
            // 
            this.pNIF.Controls.Add(this.pColorNIF);
            this.pNIF.Controls.Add(this.pbNIF);
            this.pNIF.Controls.Add(this.textBox4);
            this.pNIF.Location = new System.Drawing.Point(65, 134);
            this.pNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pNIF.Name = "pNIF";
            this.pNIF.Size = new System.Drawing.Size(439, 44);
            this.pNIF.TabIndex = 11;
            // 
            // pColorNIF
            // 
            this.pColorNIF.BackColor = System.Drawing.Color.Green;
            this.pColorNIF.Location = new System.Drawing.Point(0, 36);
            this.pColorNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pColorNIF.Name = "pColorNIF";
            this.pColorNIF.Size = new System.Drawing.Size(439, 5);
            this.pColorNIF.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(389, 22);
            this.textBox4.TabIndex = 2;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(65, 115);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(28, 16);
            this.lblNIF.TabIndex = 10;
            this.lblNIF.Text = "NIF";
            // 
            // pName
            // 
            this.pName.Controls.Add(this.pColorName);
            this.pName.Controls.Add(this.pbUsername);
            this.pName.Controls.Add(this.textBox3);
            this.pName.Location = new System.Drawing.Point(66, 58);
            this.pName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(439, 44);
            this.pName.TabIndex = 8;
            // 
            // pColorName
            // 
            this.pColorName.BackColor = System.Drawing.Color.Green;
            this.pColorName.Location = new System.Drawing.Point(0, 36);
            this.pColorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pColorName.Name = "pColorName";
            this.pColorName.Size = new System.Drawing.Size(439, 5);
            this.pColorName.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 12);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 22);
            this.textBox3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(65, 274);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.Green;
            this.btnCreateStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateStudent.Location = new System.Drawing.Point(285, 274);
            this.btnCreateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(220, 44);
            this.btnCreateStudent.TabIndex = 6;
            this.btnCreateStudent.Text = "Criar Aluno";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // pbClass
            // 
            this.pbClass.Image = global::EscolaVirtual.Properties.Resources.google_classroom;
            this.pbClass.Location = new System.Drawing.Point(399, 2);
            this.pbClass.Margin = new System.Windows.Forms.Padding(4);
            this.pbClass.Name = "pbClass";
            this.pbClass.Size = new System.Drawing.Size(32, 31);
            this.pbClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClass.TabIndex = 5;
            this.pbClass.TabStop = false;
            // 
            // pbNIF
            // 
            this.pbNIF.Image = global::EscolaVirtual.Properties.Resources._245204;
            this.pbNIF.Location = new System.Drawing.Point(399, 2);
            this.pbNIF.Margin = new System.Windows.Forms.Padding(4);
            this.pbNIF.Name = "pbNIF";
            this.pbNIF.Size = new System.Drawing.Size(32, 31);
            this.pbNIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNIF.TabIndex = 5;
            this.pbNIF.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::EscolaVirtual.Properties.Resources.icons8_pessoa_do_sexo_masculino_24;
            this.pbUsername.Location = new System.Drawing.Point(399, 2);
            this.pbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 31);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 5;
            this.pbUsername.TabStop = false;
            // 
            // FormAdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1002, 375);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdicionarAluno";
            this.Text = "FormAdicionarAluno";
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pClass.ResumeLayout(false);
            this.pNIF.ResumeLayout(false);
            this.pNIF.PerformLayout();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNIF)).EndInit();
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