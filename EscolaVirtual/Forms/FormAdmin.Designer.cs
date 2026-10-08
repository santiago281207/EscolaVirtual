namespace EscolaVirtual
{
    partial class FormAdmin
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tcCategories = new System.Windows.Forms.TabControl();
            this.tpStudent = new System.Windows.Forms.TabPage();
            this.lsvAluno = new System.Windows.Forms.ListView();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.lsvTeacher = new System.Windows.Forms.ListView();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tpYear = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.tpSubject = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tcCategories.SuspendLayout();
            this.tpStudent.SuspendLayout();
            this.tpTeacher.SuspendLayout();
            this.tpClass.SuspendLayout();
            this.tpYear.SuspendLayout();
            this.tpSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(12, 12);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(371, 50);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Adicionar Aluno";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Location = new System.Drawing.Point(12, 303);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(371, 50);
            this.btnAddYear.TabIndex = 2;
            this.btnAddYear.Text = "Adicionar Ano";
            this.btnAddYear.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 110);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(371, 50);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "Adicionar Professor";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(12, 206);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(371, 50);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Adicionar Turma";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(12, 400);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(371, 50);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.Text = "Adicionar Disciplina";
            this.btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.Location = new System.Drawing.Point(12, 498);
            this.btnLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(371, 50);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Associar Professores/Turma/Disciplina";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 736);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(371, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tcCategories
            // 
            this.tcCategories.Controls.Add(this.tpStudent);
            this.tcCategories.Controls.Add(this.tpTeacher);
            this.tcCategories.Controls.Add(this.tpClass);
            this.tcCategories.Controls.Add(this.tpYear);
            this.tcCategories.Controls.Add(this.tpSubject);
            this.tcCategories.Location = new System.Drawing.Point(435, 12);
            this.tcCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcCategories.Name = "tcCategories";
            this.tcCategories.SelectedIndex = 0;
            this.tcCategories.Size = new System.Drawing.Size(803, 778);
            this.tcCategories.TabIndex = 9;
            // 
            // tpStudent
            // 
            this.tpStudent.Controls.Add(this.lsvAluno);
            this.tpStudent.Location = new System.Drawing.Point(4, 25);
            this.tpStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudent.Size = new System.Drawing.Size(795, 749);
            this.tpStudent.TabIndex = 0;
            this.tpStudent.Text = "Aluno";
            this.tpStudent.UseVisualStyleBackColor = true;
            // 
            // lsvAluno
            // 
            this.lsvAluno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsvAluno.HideSelection = false;
            this.lsvAluno.Location = new System.Drawing.Point(5, 6);
            this.lsvAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvAluno.Name = "lsvAluno";
            this.lsvAluno.Size = new System.Drawing.Size(781, 736);
            this.lsvAluno.TabIndex = 0;
            this.lsvAluno.UseCompatibleStateImageBehavior = false;
            // 
            // tpTeacher
            // 
            this.tpTeacher.Controls.Add(this.lsvTeacher);
            this.tpTeacher.Location = new System.Drawing.Point(4, 25);
            this.tpTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTeacher.Size = new System.Drawing.Size(795, 749);
            this.tpTeacher.TabIndex = 1;
            this.tpTeacher.Text = "Professor";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // lsvTeacher
            // 
            this.lsvTeacher.HideSelection = false;
            this.lsvTeacher.Location = new System.Drawing.Point(4, 4);
            this.lsvTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvTeacher.Name = "lsvTeacher";
            this.lsvTeacher.Size = new System.Drawing.Size(781, 736);
            this.lsvTeacher.TabIndex = 0;
            this.lsvTeacher.UseCompatibleStateImageBehavior = false;
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.listView3);
            this.tpClass.Location = new System.Drawing.Point(4, 25);
            this.tpClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpClass.Name = "tpClass";
            this.tpClass.Size = new System.Drawing.Size(795, 749);
            this.tpClass.TabIndex = 2;
            this.tpClass.Text = "Turma";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(7, 6);
            this.listView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(781, 736);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tpYear
            // 
            this.tpYear.Controls.Add(this.listView4);
            this.tpYear.Location = new System.Drawing.Point(4, 25);
            this.tpYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpYear.Name = "tpYear";
            this.tpYear.Size = new System.Drawing.Size(795, 749);
            this.tpYear.TabIndex = 3;
            this.tpYear.Text = "Ano";
            this.tpYear.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(7, 6);
            this.listView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(781, 736);
            this.listView4.TabIndex = 1;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // tpSubject
            // 
            this.tpSubject.Controls.Add(this.listView5);
            this.tpSubject.Location = new System.Drawing.Point(4, 25);
            this.tpSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSubject.Name = "tpSubject";
            this.tpSubject.Size = new System.Drawing.Size(795, 749);
            this.tpSubject.TabIndex = 4;
            this.tpSubject.Text = "Disciplina";
            this.tpSubject.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(7, 6);
            this.listView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(781, 736);
            this.listView5.TabIndex = 1;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 594);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(371, 50);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tcCategories);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddYear);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.tcCategories.ResumeLayout(false);
            this.tpStudent.ResumeLayout(false);
            this.tpTeacher.ResumeLayout(false);
            this.tpClass.ResumeLayout(false);
            this.tpYear.ResumeLayout(false);
            this.tpSubject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tcCategories;
        private System.Windows.Forms.TabPage tpStudent;
        private System.Windows.Forms.TabPage tpTeacher;
        private System.Windows.Forms.ListView lsvAluno;
        private System.Windows.Forms.ListView lsvTeacher;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage tpYear;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.TabPage tpSubject;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Button btnEdit;
    }
}