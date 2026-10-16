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
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNifStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClassYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.lvwTeacher = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNifTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeacherEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeacherContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeacherAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpClass = new System.Windows.Forms.TabPage();
            this.lvwClass = new System.Windows.Forms.ListView();
            this.chClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStudentQtt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSchoolYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpYear = new System.Windows.Forms.TabPage();
            this.lvwYear = new System.Windows.Forms.ListView();
            this.chYearName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClassQtt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubjectQtt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSubject = new System.Windows.Forms.TabPage();
            this.lvwSubject = new System.Windows.Forms.ListView();
            this.chSubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClassYearSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModules = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.pAdmin = new System.Windows.Forms.Panel();
            this.pAdminSair = new System.Windows.Forms.Panel();
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
            this.btnAddStudent.Location = new System.Drawing.Point(327, 511);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(278, 41);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Adicionar Aluno";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.BackColor = System.Drawing.Color.Green;
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddYear.Location = new System.Drawing.Point(327, 448);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(278, 41);
            this.btnAddYear.TabIndex = 2;
            this.btnAddYear.Text = "Adicionar Ano";
            this.btnAddYear.UseVisualStyleBackColor = false;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Green;
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTeacher.Location = new System.Drawing.Point(637, 511);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(278, 41);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "Adicionar Professor";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.Green;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(14, 511);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(278, 41);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Adicionar Turma";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Green;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubject.Location = new System.Drawing.Point(637, 448);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(278, 41);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.Text = "Adicionar Disciplina";
            this.btnSubject.UseVisualStyleBackColor = false;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.Green;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLink.Location = new System.Drawing.Point(637, 8);
            this.btnLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(278, 41);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Associar Professores/Turma/Disciplina";
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(10, 8);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(278, 41);
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
            this.tcCategories.Location = new System.Drawing.Point(10, 11);
            this.tcCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcCategories.Name = "tcCategories";
            this.tcCategories.SelectedIndex = 0;
            this.tcCategories.Size = new System.Drawing.Size(892, 421);
            this.tcCategories.TabIndex = 9;
            this.tcCategories.SelectedIndexChanged += new System.EventHandler(this.tcCategories_SelectedIndexChanged);
            // 
            // tpStudent
            // 
            this.tpStudent.Controls.Add(this.lvwStudent);
            this.tpStudent.Location = new System.Drawing.Point(4, 22);
            this.tpStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpStudent.Size = new System.Drawing.Size(884, 395);
            this.tpStudent.TabIndex = 0;
            this.tpStudent.Text = "Aluno";
            this.tpStudent.UseVisualStyleBackColor = true;
            // 
            // lvwStudent
            // 
            this.lvwStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chNifStudent,
            this.chClassYear,
            this.chClassName,
            this.chMessageCount,
            this.chAverage,
            this.chEmail,
            this.chPhoneNumber,
            this.chAddress});
            this.lvwStudent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvwStudent.HideSelection = false;
            this.lvwStudent.Location = new System.Drawing.Point(2, 3);
            this.lvwStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwStudent.Name = "lvwStudent";
            this.lvwStudent.Size = new System.Drawing.Size(882, 395);
            this.lvwStudent.TabIndex = 0;
            this.lvwStudent.UseCompatibleStateImageBehavior = false;
            this.lvwStudent.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Nome";
            this.chName.Width = 80;
            // 
            // chNifStudent
            // 
            this.chNifStudent.Text = "NIF";
            this.chNifStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNifStudent.Width = 100;
            // 
            // chClassYear
            // 
            this.chClassYear.Text = "Ano";
            this.chClassYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chClassName
            // 
            this.chClassName.Text = "Turma";
            this.chClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClassName.Width = 80;
            // 
            // chMessageCount
            // 
            this.chMessageCount.Text = "Quantidade de mensagens";
            this.chMessageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMessageCount.Width = 100;
            // 
            // chAverage
            // 
            this.chAverage.Text = "Média";
            this.chAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAverage.Width = 130;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmail.Width = 120;
            // 
            // chPhoneNumber
            // 
            this.chPhoneNumber.Text = "Contacto";
            this.chPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhoneNumber.Width = 70;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Morada";
            this.chAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAddress.Width = 130;
            // 
            // tpTeacher
            // 
            this.tpTeacher.Controls.Add(this.lvwTeacher);
            this.tpTeacher.Location = new System.Drawing.Point(4, 22);
            this.tpTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpTeacher.Size = new System.Drawing.Size(884, 395);
            this.tpTeacher.TabIndex = 1;
            this.tpTeacher.Text = "Professor";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // lvwTeacher
            // 
            this.lvwTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chClasses,
            this.chNifTeacher,
            this.chTeacherEmail,
            this.chTeacherContact,
            this.chTeacherAddress});
            this.lvwTeacher.HideSelection = false;
            this.lvwTeacher.Location = new System.Drawing.Point(2, 2);
            this.lvwTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwTeacher.Name = "lvwTeacher";
            this.lvwTeacher.Size = new System.Drawing.Size(882, 395);
            this.lvwTeacher.TabIndex = 2;
            this.lvwTeacher.UseCompatibleStateImageBehavior = false;
            this.lvwTeacher.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 130;
            // 
            // chClasses
            // 
            this.chClasses.Text = "Quantidade de turmas";
            this.chClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClasses.Width = 130;
            // 
            // chNifTeacher
            // 
            this.chNifTeacher.Text = "NIF";
            this.chNifTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNifTeacher.Width = 80;
            // 
            // chTeacherEmail
            // 
            this.chTeacherEmail.Text = "Email";
            this.chTeacherEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTeacherEmail.Width = 120;
            // 
            // chTeacherContact
            // 
            this.chTeacherContact.Text = "Contacto";
            this.chTeacherContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTeacherContact.Width = 100;
            // 
            // chTeacherAddress
            // 
            this.chTeacherAddress.Text = "Morada";
            this.chTeacherAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTeacherAddress.Width = 140;
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.lvwClass);
            this.tpClass.Location = new System.Drawing.Point(4, 22);
            this.tpClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpClass.Name = "tpClass";
            this.tpClass.Size = new System.Drawing.Size(884, 395);
            this.tpClass.TabIndex = 2;
            this.tpClass.Text = "Turma";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // lvwClass
            // 
            this.lvwClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chClass,
            this.chStudentQtt,
            this.chSchoolYear});
            this.lvwClass.HideSelection = false;
            this.lvwClass.Location = new System.Drawing.Point(0, 0);
            this.lvwClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwClass.Name = "lvwClass";
            this.lvwClass.Size = new System.Drawing.Size(882, 395);
            this.lvwClass.TabIndex = 1;
            this.lvwClass.UseCompatibleStateImageBehavior = false;
            this.lvwClass.View = System.Windows.Forms.View.Details;
            // 
            // chClass
            // 
            this.chClass.Text = "Nome da Turma";
            this.chClass.Width = 130;
            // 
            // chStudentQtt
            // 
            this.chStudentQtt.Text = "Quantidade de alunos";
            this.chStudentQtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStudentQtt.Width = 150;
            // 
            // chSchoolYear
            // 
            this.chSchoolYear.Text = "Ano";
            this.chSchoolYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSchoolYear.Width = 130;
            // 
            // tpYear
            // 
            this.tpYear.Controls.Add(this.lvwYear);
            this.tpYear.Location = new System.Drawing.Point(4, 22);
            this.tpYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpYear.Name = "tpYear";
            this.tpYear.Size = new System.Drawing.Size(884, 395);
            this.tpYear.TabIndex = 3;
            this.tpYear.Text = "Ano";
            this.tpYear.UseVisualStyleBackColor = true;
            // 
            // lvwYear
            // 
            this.lvwYear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chYearName,
            this.chClassQtt,
            this.chSubjectQtt});
            this.lvwYear.HideSelection = false;
            this.lvwYear.Location = new System.Drawing.Point(2, 2);
            this.lvwYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwYear.Name = "lvwYear";
            this.lvwYear.Size = new System.Drawing.Size(882, 395);
            this.lvwYear.TabIndex = 1;
            this.lvwYear.UseCompatibleStateImageBehavior = false;
            this.lvwYear.View = System.Windows.Forms.View.Details;
            // 
            // chYearName
            // 
            this.chYearName.Text = "Ano";
            this.chYearName.Width = 80;
            // 
            // chClassQtt
            // 
            this.chClassQtt.Text = "Quantidade de Turmas";
            this.chClassQtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClassQtt.Width = 150;
            // 
            // chSubjectQtt
            // 
            this.chSubjectQtt.Text = "Quantidade de Disciplinas";
            this.chSubjectQtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSubjectQtt.Width = 170;
            // 
            // tpSubject
            // 
            this.tpSubject.Controls.Add(this.lvwSubject);
            this.tpSubject.Location = new System.Drawing.Point(4, 22);
            this.tpSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSubject.Name = "tpSubject";
            this.tpSubject.Size = new System.Drawing.Size(884, 395);
            this.tpSubject.TabIndex = 4;
            this.tpSubject.Text = "Disciplina";
            this.tpSubject.UseVisualStyleBackColor = true;
            // 
            // lvwSubject
            // 
            this.lvwSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSubjectName,
            this.chClassYearSubject,
            this.chModules});
            this.lvwSubject.HideSelection = false;
            this.lvwSubject.Location = new System.Drawing.Point(2, 0);
            this.lvwSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwSubject.Name = "lvwSubject";
            this.lvwSubject.Size = new System.Drawing.Size(882, 395);
            this.lvwSubject.TabIndex = 1;
            this.lvwSubject.UseCompatibleStateImageBehavior = false;
            this.lvwSubject.View = System.Windows.Forms.View.Details;
            // 
            // chSubjectName
            // 
            this.chSubjectName.Text = "Disciplina";
            this.chSubjectName.Width = 150;
            // 
            // chClassYearSubject
            // 
            this.chClassYearSubject.Text = "Ano";
            this.chClassYearSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClassYearSubject.Width = 100;
            // 
            // chModules
            // 
            this.chModules.Text = "Módulos";
            this.chModules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chModules.Width = 150;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(14, 448);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(278, 41);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
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
            this.pAdmin.Location = new System.Drawing.Point(9, 11);
            this.pAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(925, 570);
            this.pAdmin.TabIndex = 11;
            // 
            // pAdminSair
            // 
            this.pAdminSair.BackColor = System.Drawing.Color.Silver;
            this.pAdminSair.Controls.Add(this.btnLogOut);
            this.pAdminSair.Controls.Add(this.btnLink);
            this.pAdminSair.Location = new System.Drawing.Point(9, 587);
            this.pAdminSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pAdminSair.Name = "pAdminSair";
            this.pAdminSair.Size = new System.Drawing.Size(925, 53);
            this.pAdminSair.TabIndex = 12;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pAdminSair);
            this.Controls.Add(this.pAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
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
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chNifStudent;
        private System.Windows.Forms.ColumnHeader chClassYear;
        private System.Windows.Forms.ColumnHeader chClassName;
        private System.Windows.Forms.ColumnHeader chMessageCount;
        private System.Windows.Forms.ColumnHeader chAverage;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chClasses;
        private System.Windows.Forms.ColumnHeader chClass;
        private System.Windows.Forms.ColumnHeader chStudentQtt;
        private System.Windows.Forms.ColumnHeader chSchoolYear;
        private System.Windows.Forms.ColumnHeader chYearName;
        private System.Windows.Forms.ColumnHeader chClassQtt;
        private System.Windows.Forms.ColumnHeader chSubjectQtt;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chPhoneNumber;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chNifTeacher;
        private System.Windows.Forms.ColumnHeader chTeacherEmail;
        private System.Windows.Forms.ColumnHeader chTeacherContact;
        private System.Windows.Forms.ColumnHeader chTeacherAddress;
        private System.Windows.Forms.ColumnHeader chSubjectName;
        private System.Windows.Forms.ColumnHeader chClassYearSubject;
        private System.Windows.Forms.ColumnHeader chModules;
    }
}