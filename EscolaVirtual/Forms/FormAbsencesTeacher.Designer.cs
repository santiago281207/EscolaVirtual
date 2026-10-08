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
            this.grbJustified.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(9, 28);
            this.cbClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(235, 21);
            this.cbClass.TabIndex = 0;
            // 
            // cbStudend
            // 
            this.cbStudend.FormattingEnabled = true;
            this.cbStudend.Location = new System.Drawing.Point(9, 74);
            this.cbStudend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStudend.Name = "cbStudend";
            this.cbStudend.Size = new System.Drawing.Size(235, 21);
            this.cbStudend.TabIndex = 1;
            // 
            // rbJustified
            // 
            this.rbJustified.AutoSize = true;
            this.rbJustified.Location = new System.Drawing.Point(125, 31);
            this.rbJustified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJustified.Name = "rbJustified";
            this.rbJustified.Size = new System.Drawing.Size(75, 17);
            this.rbJustified.TabIndex = 2;
            this.rbJustified.Text = "Justificada";
            this.rbJustified.UseVisualStyleBackColor = true;
            // 
            // rbNotJustified
            // 
            this.rbNotJustified.AutoSize = true;
            this.rbNotJustified.Checked = true;
            this.rbNotJustified.Location = new System.Drawing.Point(22, 31);
            this.rbNotJustified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNotJustified.Name = "rbNotJustified";
            this.rbNotJustified.Size = new System.Drawing.Size(81, 17);
            this.rbNotJustified.TabIndex = 3;
            this.rbNotJustified.TabStop = true;
            this.rbNotJustified.Text = "Injustificada";
            this.rbNotJustified.UseVisualStyleBackColor = true;
            // 
            // grbJustified
            // 
            this.grbJustified.Controls.Add(this.rbNotJustified);
            this.grbJustified.Controls.Add(this.rbJustified);
            this.grbJustified.Location = new System.Drawing.Point(9, 107);
            this.grbJustified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbJustified.Name = "grbJustified";
            this.grbJustified.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbJustified.Size = new System.Drawing.Size(234, 64);
            this.grbJustified.TabIndex = 4;
            this.grbJustified.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(7, 13);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Truma";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(9, 58);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(34, 13);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "Aluno";
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.Location = new System.Drawing.Point(11, 192);
            this.dtpAbsenceDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(233, 20);
            this.dtpAbsenceDate.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(319, 248);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 44);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 248);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 44);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FormAbsencesTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpAbsenceDate);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.grbJustified);
            this.Controls.Add(this.cbStudend);
            this.Controls.Add(this.cbClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbsencesTeacher";
            this.Text = "FormAbsencesTeacher";
            this.grbJustified.ResumeLayout(false);
            this.grbJustified.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}