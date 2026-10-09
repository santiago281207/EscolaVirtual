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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tcCategories = new System.Windows.Forms.TabControl();
            this.tpStudent = new System.Windows.Forms.TabPage();
            this.lvwStudent = new System.Windows.Forms.ListView();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.lvwClass = new System.Windows.Forms.ListView();
            this.tpYear = new System.Windows.Forms.TabPage();
            this.lvwYear = new System.Windows.Forms.ListView();
            this.tpSubject = new System.Windows.Forms.TabPage();
            this.lvwSubject = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pAdmin = new System.Windows.Forms.Panel();
            this.pAdminSair = new System.Windows.Forms.Panel();
            this.lvwTeacher = new System.Windows.Forms.ListView();
            this.tcCategories.SuspendLayout();
            this.tpStudent.SuspendLayout();
            this.tpTeacher.SuspendLayout();
            this.tpClass.SuspendLayout();
            this.tpYear.SuspendLayout();
            this.tpSubject.SuspendLayout();
            this.pAdmin.SuspendLayout();
            this.pAdminSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Green;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(436, 629);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(371, 50);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Adicionar Aluno";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // btnAddYear
            // 
            this.btnAddYear.BackColor = System.Drawing.Color.Green;
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddYear.Location = new System.Drawing.Point(436, 552);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(371, 50);
            this.btnAddYear.TabIndex = 2;
            this.btnAddYear.Text = "Adicionar Ano";
            this.btnAddYear.UseVisualStyleBackColor = false;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Green;
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTeacher.Location = new System.Drawing.Point(849, 629);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(371, 50);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "Adicionar Professor";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.Green;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(18, 629);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(371, 50);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Adicionar Turma";
            this.btnAddClass.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Green;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubject.Location = new System.Drawing.Point(849, 552);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(371, 50);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.Text = "Adicionar Disciplina";
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.Green;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLink.Location = new System.Drawing.Point(849, 10);
            this.btnLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(371, 50);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Associar Professores/Turma/Disciplina";
            this.btnLink.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(14, 10);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(371, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tcCategories
            // 
            this.tcCategories.Controls.Add(this.tpStudent);
            this.tcCategories.Controls.Add(this.tpTeacher);
            this.tcCategories.Controls.Add(this.tpClass);
            this.tcCategories.Controls.Add(this.tpYear);
            this.tcCategories.Controls.Add(this.tpSubject);
            this.tcCategories.Location = new System.Drawing.Point(14, 13);
            this.tcCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcCategories.Name = "tcCategories";
            this.tcCategories.SelectedIndex = 0;
            this.tcCategories.Size = new System.Drawing.Size(1189, 518);
            this.tcCategories.TabIndex = 9;
            // 
            // tpStudent
            // 
            this.tpStudent.Controls.Add(this.lvwStudent);
            this.tpStudent.Location = new System.Drawing.Point(4, 25);
            this.tpStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStudent.Size = new System.Drawing.Size(1181, 489);
            this.tpStudent.TabIndex = 0;
            this.tpStudent.Text = "Aluno";
            this.tpStudent.UseVisualStyleBackColor = true;
            // 
            // lvwStudent
            // 
            this.lvwStudent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvwStudent.HideSelection = false;
            this.lvwStudent.Location = new System.Drawing.Point(3, 4);
            this.lvwStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwStudent.Name = "lvwStudent";
            this.lvwStudent.Size = new System.Drawing.Size(1175, 485);
            this.lvwStudent.TabIndex = 0;
            this.lvwStudent.UseCompatibleStateImageBehavior = false;
            this.lvwStudent.SelectedIndexChanged += new System.EventHandler(this.lvwStudent_SelectedIndexChanged);
            // 
            // tpTeacher
            // 
            this.tpTeacher.Controls.Add(this.lvwTeacher);
            this.tpTeacher.Location = new System.Drawing.Point(4, 25);
            this.tpTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTeacher.Size = new System.Drawing.Size(1181, 489);
            this.tpTeacher.TabIndex = 1;
            this.tpTeacher.Text = "Professor";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.lvwClass);
            this.tpClass.Location = new System.Drawing.Point(4, 25);
            this.tpClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpClass.Name = "tpClass";
            this.tpClass.Size = new System.Drawing.Size(1181, 489);
            this.tpClass.TabIndex = 2;
            this.tpClass.Text = "Turma";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // lvwClass
            // 
            this.lvwClass.HideSelection = false;
            this.lvwClass.Location = new System.Drawing.Point(0, 0);
            this.lvwClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwClass.Name = "lvwClass";
            this.lvwClass.Size = new System.Drawing.Size(1175, 485);
            this.lvwClass.TabIndex = 1;
            this.lvwClass.UseCompatibleStateImageBehavior = false;
            // 
            // tpYear
            // 
            this.tpYear.Controls.Add(this.lvwYear);
            this.tpYear.Location = new System.Drawing.Point(4, 25);
            this.tpYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpYear.Name = "tpYear";
            this.tpYear.Size = new System.Drawing.Size(1181, 489);
            this.tpYear.TabIndex = 3;
            this.tpYear.Text = "Ano";
            this.tpYear.UseVisualStyleBackColor = true;
            // 
            // lvwYear
            // 
            this.lvwYear.HideSelection = false;
            this.lvwYear.Location = new System.Drawing.Point(3, 2);
            this.lvwYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwYear.Name = "lvwYear";
            this.lvwYear.Size = new System.Drawing.Size(1175, 485);
            this.lvwYear.TabIndex = 1;
            this.lvwYear.UseCompatibleStateImageBehavior = false;
            // 
            // tpSubject
            // 
            this.tpSubject.Controls.Add(this.lvwSubject);
            this.tpSubject.Location = new System.Drawing.Point(4, 25);
            this.tpSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSubject.Name = "tpSubject";
            this.tpSubject.Size = new System.Drawing.Size(1181, 489);
            this.tpSubject.TabIndex = 4;
            this.tpSubject.Text = "Disciplina";
            this.tpSubject.UseVisualStyleBackColor = true;
            // 
            // lvwSubject
            // 
            this.lvwSubject.HideSelection = false;
            this.lvwSubject.Location = new System.Drawing.Point(3, 0);
            this.lvwSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwSubject.Name = "lvwSubject";
            this.lvwSubject.Size = new System.Drawing.Size(1175, 485);
            this.lvwSubject.TabIndex = 1;
            this.lvwSubject.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(18, 552);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(371, 50);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pAdmin
            // 
            this.pAdmin.BackColor = System.Drawing.Color.Silver;
            this.pAdmin.Controls.Add(this.tcCategories);
            this.pAdmin.Controls.Add(this.btnEdit);
            this.pAdmin.Controls.Add(this.btnSubject);
            this.pAdmin.Controls.Add(this.btnAddTeacher);
            this.pAdmin.Controls.Add(this.btnAddClass);
            this.pAdmin.Controls.Add(this.btnAddYear);
            this.pAdmin.Controls.Add(this.btnAddStudent);
            this.pAdmin.Location = new System.Drawing.Point(12, 13);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(1233, 701);
            this.pAdmin.TabIndex = 11;
            // 
            // pAdminSair
            // 
            this.pAdminSair.BackColor = System.Drawing.Color.Silver;
            this.pAdminSair.Controls.Add(this.btnLogOut);
            this.pAdminSair.Controls.Add(this.btnLink);
            this.pAdminSair.Location = new System.Drawing.Point(12, 723);
            this.pAdminSair.Name = "pAdminSair";
            this.pAdminSair.Size = new System.Drawing.Size(1233, 65);
            this.pAdminSair.TabIndex = 12;
            // 
            // lvwTeacher
            // 
            this.lvwTeacher.HideSelection = false;
            this.lvwTeacher.Location = new System.Drawing.Point(3, 2);
            this.lvwTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwTeacher.Name = "lvwTeacher";
            this.lvwTeacher.Size = new System.Drawing.Size(1175, 485);
            this.lvwTeacher.TabIndex = 2;
            this.lvwTeacher.UseCompatibleStateImageBehavior = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.pAdminSair);
            this.Controls.Add(this.pAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.tcCategories.ResumeLayout(false);
            this.tpStudent.ResumeLayout(false);
            this.tpTeacher.ResumeLayout(false);
            this.tpClass.ResumeLayout(false);
            this.tpYear.ResumeLayout(false);
            this.tpSubject.ResumeLayout(false);
            this.pAdmin.ResumeLayout(false);
            this.pAdminSair.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvwStudent;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.ListView lvwClass;
        private System.Windows.Forms.TabPage tpYear;
        private System.Windows.Forms.ListView lvwYear;
        private System.Windows.Forms.TabPage tpSubject;
        private System.Windows.Forms.ListView lvwSubject;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pAdmin;
        private System.Windows.Forms.Panel pAdminSair;
        private System.Windows.Forms.ListView lvwTeacher;
    }
}