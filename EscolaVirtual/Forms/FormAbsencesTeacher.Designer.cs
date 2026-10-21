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
            this.cbStudent = new System.Windows.Forms.ComboBox();
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbJustified.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(16, 47);
            this.cbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(191, 24);
            this.cbClass.TabIndex = 0;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.Enabled = false;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(336, 47);
            this.cbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(191, 24);
            this.cbStudent.TabIndex = 1;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
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
            this.rbJustified.CheckedChanged += new System.EventHandler(this.rbJustified_CheckedChanged);
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
            this.grbJustified.Location = new System.Drawing.Point(15, 169);
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
            this.lblClass.Location = new System.Drawing.Point(13, 30);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Turma";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(333, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(41, 16);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "Aluno";
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.Location = new System.Drawing.Point(332, 105);
            this.dtpAbsenceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(215, 22);
            this.dtpAbsenceDate.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.Enabled = false;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(16, 14);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(157, 54);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(389, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 54);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(15, 432);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 91);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblSubject);
            this.panel2.Controls.Add(this.cbSubject);
            this.panel2.Controls.Add(this.txtJustification);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblStudent);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.cbStudent);
            this.panel2.Controls.Add(this.dtpAbsenceDate);
            this.panel2.Controls.Add(this.cbClass);
            this.panel2.Controls.Add(this.grbJustified);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 412);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(19, 126);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 4);
            this.panel3.TabIndex = 21;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(16, 84);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(66, 16);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Disciplina";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.Enabled = false;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(19, 101);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(191, 24);
            this.cbSubject.TabIndex = 19;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // txtJustification
            // 
            this.txtJustification.Enabled = false;
            this.txtJustification.Location = new System.Drawing.Point(15, 270);
            this.txtJustification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJustification.MaxLength = 2000;
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(531, 128);
            this.txtJustification.TabIndex = 18;
            this.txtJustification.TextChanged += new System.EventHandler(this.txtJustification_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(3, 405);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 10);
            this.panel4.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(332, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Data da Falta";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(333, 126);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 4);
            this.panel7.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(336, 71);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 4);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(16, 71);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 4);
            this.panel5.TabIndex = 14;
            // 
            // FormAbsencesTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbsencesTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbsencesTeacher";
            this.Load += new System.EventHandler(this.FormAbsencesTeacher_Load);
            this.grbJustified.ResumeLayout(false);
            this.grbJustified.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbStudent;
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}