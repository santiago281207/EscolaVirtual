namespace EscolaVirtual
{
    partial class FormAbsencesTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbsencesTeacher));
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbStudend = new System.Windows.Forms.ComboBox();
            this.rbJustified = new System.Windows.Forms.RadioButton();
            this.rbNotJustified = new System.Windows.Forms.RadioButton();
            this.grbJustified = new System.Windows.Forms.GroupBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.dtpAbsenceDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbJustified.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(16, 47);
            this.cbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(190, 24);
            this.cbClass.TabIndex = 0;
            // 
            // cbStudend
            // 
            this.cbStudend.FormattingEnabled = true;
            this.cbStudend.Location = new System.Drawing.Point(333, 47);
            this.cbStudend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudend.Name = "cbStudend";
            this.cbStudend.Size = new System.Drawing.Size(190, 24);
            this.cbStudend.TabIndex = 1;
            // 
            // rbJustified
            // 
            this.rbJustified.AutoSize = true;
            this.rbJustified.Location = new System.Drawing.Point(167, 38);
            this.rbJustified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJustified.Name = "rbJustified";
            this.rbJustified.Size = new System.Drawing.Size(92, 20);
            this.rbJustified.TabIndex = 2;
            this.rbJustified.Text = "Justificada";
            this.rbJustified.UseVisualStyleBackColor = true;
            // 
            // rbNotJustified
            // 
            this.rbNotJustified.AutoSize = true;
            this.rbNotJustified.Checked = true;
            this.rbNotJustified.Location = new System.Drawing.Point(29, 38);
            this.rbNotJustified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNotJustified.Name = "rbNotJustified";
            this.rbNotJustified.Size = new System.Drawing.Size(98, 20);
            this.rbNotJustified.TabIndex = 3;
            this.rbNotJustified.TabStop = true;
            this.rbNotJustified.Text = "Injustificada";
            this.rbNotJustified.UseVisualStyleBackColor = true;
            // 
            // grbJustified
            // 
            this.grbJustified.BackColor = System.Drawing.Color.White;
            this.grbJustified.Controls.Add(this.rbNotJustified);
            this.grbJustified.Controls.Add(this.rbJustified);
            this.grbJustified.Location = new System.Drawing.Point(16, 123);
            this.grbJustified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbJustified.Name = "grbJustified";
            this.grbJustified.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbJustified.Size = new System.Drawing.Size(277, 79);
            this.grbJustified.TabIndex = 4;
            this.grbJustified.TabStop = false;
            this.grbJustified.Text = "Faltas";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(13, 29);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Turma";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(330, 29);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(41, 16);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "Aluno";
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.Location = new System.Drawing.Point(332, 148);
            this.dtpAbsenceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(215, 22);
            this.dtpAbsenceDate.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(16, 14);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(157, 54);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(390, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 54);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(15, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 84);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblStudent);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.cbStudend);
            this.panel2.Controls.Add(this.dtpAbsenceDate);
            this.panel2.Controls.Add(this.cbClass);
            this.panel2.Controls.Add(this.grbJustified);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 239);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 16);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(0, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 10);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(16, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 4);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(333, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 4);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(333, 169);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 4);
            this.panel7.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(332, 123);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Data da Falta";
            // 
            // FormAbsencesTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbsencesTeacher";
            this.Text = "FormAbsencesTeacher";
            this.grbJustified.ResumeLayout(false);
            this.grbJustified.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbStudend;
        private System.Windows.Forms.RadioButton rbJustified;
        private System.Windows.Forms.RadioButton rbNotJustified;
        private System.Windows.Forms.GroupBox grbJustified;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DateTimePicker dtpAbsenceDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}