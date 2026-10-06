namespace EscolaVirtual
{
    partial class FormTeacher
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
            this.lblteacher = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tvwClassSubject = new System.Windows.Forms.TreeView();
            this.btnGradeStudent = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tvwAvg = new System.Windows.Forms.TreeView();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lblClassSubject = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.Location = new System.Drawing.Point(19, 9);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(85, 29);
            this.lblteacher.TabIndex = 2;
            this.lblteacher.Text = "label1";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(1057, 719);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(186, 69);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Exit";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // tvwClassSubject
            // 
            this.tvwClassSubject.Location = new System.Drawing.Point(738, 114);
            this.tvwClassSubject.Name = "tvwClassSubject";
            this.tvwClassSubject.Size = new System.Drawing.Size(505, 599);
            this.tvwClassSubject.TabIndex = 11;
            // 
            // btnGradeStudent
            // 
            this.btnGradeStudent.Location = new System.Drawing.Point(24, 114);
            this.btnGradeStudent.Name = "btnGradeStudent";
            this.btnGradeStudent.Size = new System.Drawing.Size(186, 69);
            this.btnGradeStudent.TabIndex = 12;
            this.btnGradeStudent.Text = "Notas";
            this.btnGradeStudent.UseVisualStyleBackColor = true;
            this.btnGradeStudent.Click += new System.EventHandler(this.btnGradeStudent_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(24, 189);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(186, 69);
            this.btnAbsence.TabIndex = 13;
            this.btnAbsence.Text = "Faltas";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(24, 264);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(186, 69);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Alterar Dados";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tvwAvg
            // 
            this.tvwAvg.Location = new System.Drawing.Point(244, 114);
            this.tvwAvg.Name = "tvwAvg";
            this.tvwAvg.Size = new System.Drawing.Size(465, 599);
            this.tvwAvg.TabIndex = 15;
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(24, 339);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(186, 69);
            this.btnMessages.TabIndex = 16;
            this.btnMessages.Text = "Mensagems";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // lblClassSubject
            // 
            this.lblClassSubject.AutoSize = true;
            this.lblClassSubject.Location = new System.Drawing.Point(735, 95);
            this.lblClassSubject.Name = "lblClassSubject";
            this.lblClassSubject.Size = new System.Drawing.Size(184, 16);
            this.lblClassSubject.TabIndex = 17;
            this.lblClassSubject.Text = " Consultar turmar e disciplinas";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(241, 95);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(305, 16);
            this.lblAvg.TabIndex = 18;
            this.lblAvg.Text = "Consultar média da turma e resultados dos alunos";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblClassSubject);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.tvwAvg);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnGradeStudent);
            this.Controls.Add(this.tvwClassSubject);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblteacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TreeView tvwClassSubject;
        private System.Windows.Forms.Button btnGradeStudent;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TreeView tvwAvg;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Label lblClassSubject;
        private System.Windows.Forms.Label lblAvg;
    }
}