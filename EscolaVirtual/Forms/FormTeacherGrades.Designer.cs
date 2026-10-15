namespace EscolaVirtual.Forms
{
    partial class FormTeacherGrades
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(16, 46);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(214, 24);
            this.cbClass.TabIndex = 0;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(13, 218);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 16);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Nota";
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(16, 237);
            this.nudGrade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(120, 22);
            this.nudGrade.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(13, 27);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Turma";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(16, 95);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(214, 24);
            this.cbStudent.TabIndex = 6;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(13, 76);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(67, 16);
            this.lblStudent.TabIndex = 7;
            this.lblStudent.Text = "Estudante";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(16, 145);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(214, 24);
            this.cbSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 122);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(66, 16);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = "Disciplina";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(13, 172);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(52, 16);
            this.lblModule.TabIndex = 10;
            this.lblModule.Text = "Modulo";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(16, 191);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(214, 24);
            this.cbModule.TabIndex = 11;
            // 
            // FormTeacherGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 370);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cbClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTeacherGrades";
            this.Text = "Professor Notas";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cbModule;
    }
}