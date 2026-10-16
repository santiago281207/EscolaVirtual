namespace EscolaVirtual
{
    partial class FormAbsencesStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbsencesStudent));
            this.lblJustification = new System.Windows.Forms.Label();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.grbAbsenceState = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAllAbsences = new System.Windows.Forms.RadioButton();
            this.rbUnjustified = new System.Windows.Forms.RadioButton();
            this.rbJustified = new System.Windows.Forms.RadioButton();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.pDescricao = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pEstado = new System.Windows.Forms.Panel();
            this.lvwAbsences = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJustification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbAbsenceState.SuspendLayout();
            this.pDescricao.SuspendLayout();
            this.pEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJustification
            // 
            this.lblJustification.AutoSize = true;
            this.lblJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustification.Location = new System.Drawing.Point(28, 22);
            this.lblJustification.Name = "lblJustification";
            this.lblJustification.Size = new System.Drawing.Size(211, 25);
            this.lblJustification.TabIndex = 2;
            this.lblJustification.Text = "Justificação de Falta";
            // 
            // txtJustification
            // 
            this.txtJustification.Location = new System.Drawing.Point(16, 42);
            this.txtJustification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(424, 586);
            this.txtJustification.TabIndex = 3;
            // 
            // grbAbsenceState
            // 
            this.grbAbsenceState.BackColor = System.Drawing.Color.White;
            this.grbAbsenceState.Controls.Add(this.panel3);
            this.grbAbsenceState.Controls.Add(this.rbAllAbsences);
            this.grbAbsenceState.Controls.Add(this.rbUnjustified);
            this.grbAbsenceState.Controls.Add(this.rbJustified);
            this.grbAbsenceState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbsenceState.Location = new System.Drawing.Point(20, 14);
            this.grbAbsenceState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAbsenceState.Name = "grbAbsenceState";
            this.grbAbsenceState.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAbsenceState.Size = new System.Drawing.Size(642, 135);
            this.grbAbsenceState.TabIndex = 6;
            this.grbAbsenceState.TabStop = false;
            this.grbAbsenceState.Text = "Estado de Falta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 5);
            this.panel3.TabIndex = 11;
            // 
            // rbAllAbsences
            // 
            this.rbAllAbsences.AutoSize = true;
            this.rbAllAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllAbsences.Location = new System.Drawing.Point(5, 98);
            this.rbAllAbsences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAllAbsences.Name = "rbAllAbsences";
            this.rbAllAbsences.Size = new System.Drawing.Size(160, 26);
            this.rbAllAbsences.TabIndex = 7;
            this.rbAllAbsences.TabStop = true;
            this.rbAllAbsences.Text = "Todas as Faltas";
            this.rbAllAbsences.UseVisualStyleBackColor = true;
            this.rbAllAbsences.CheckedChanged += new System.EventHandler(this.rbAllAbsences_CheckedChanged);
            // 
            // rbUnjustified
            // 
            this.rbUnjustified.AutoSize = true;
            this.rbUnjustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnjustified.Location = new System.Drawing.Point(5, 63);
            this.rbUnjustified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUnjustified.Name = "rbUnjustified";
            this.rbUnjustified.Size = new System.Drawing.Size(125, 26);
            this.rbUnjustified.TabIndex = 8;
            this.rbUnjustified.TabStop = true;
            this.rbUnjustified.Text = "Injustificada";
            this.rbUnjustified.UseVisualStyleBackColor = true;
            this.rbUnjustified.CheckedChanged += new System.EventHandler(this.rbUnjustified_CheckedChanged);
            // 
            // rbJustified
            // 
            this.rbJustified.AutoSize = true;
            this.rbJustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJustified.Location = new System.Drawing.Point(5, 30);
            this.rbJustified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJustified.Name = "rbJustified";
            this.rbJustified.Size = new System.Drawing.Size(116, 26);
            this.rbJustified.TabIndex = 9;
            this.rbJustified.TabStop = true;
            this.rbJustified.Text = "Justificada";
            this.rbJustified.UseVisualStyleBackColor = true;
            this.rbJustified.CheckedChanged += new System.EventHandler(this.rbJustified_CheckedChanged);
            // 
            // pCorUsername
            // 
            this.pCorUsername.BackColor = System.Drawing.Color.Green;
            this.pCorUsername.Location = new System.Drawing.Point(17, 629);
            this.pCorUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pCorUsername.Name = "pCorUsername";
            this.pCorUsername.Size = new System.Drawing.Size(424, 5);
            this.pCorUsername.TabIndex = 7;
            // 
            // pDescricao
            // 
            this.pDescricao.BackColor = System.Drawing.Color.Silver;
            this.pDescricao.Controls.Add(this.btnConfirm);
            this.pDescricao.Controls.Add(this.lblDescription);
            this.pDescricao.Controls.Add(this.txtJustification);
            this.pDescricao.Controls.Add(this.pCorUsername);
            this.pDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pDescricao.Location = new System.Drawing.Point(33, 68);
            this.pDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.pDescricao.Name = "pDescricao";
            this.pDescricao.Size = new System.Drawing.Size(463, 700);
            this.pDescricao.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(16, 647);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(425, 37);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(17, 14);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Descrição";
            // 
            // pEstado
            // 
            this.pEstado.BackColor = System.Drawing.Color.Silver;
            this.pEstado.Controls.Add(this.lvwAbsences);
            this.pEstado.Controls.Add(this.btnExit);
            this.pEstado.Controls.Add(this.panel4);
            this.pEstado.Controls.Add(this.grbAbsenceState);
            this.pEstado.Location = new System.Drawing.Point(547, 68);
            this.pEstado.Margin = new System.Windows.Forms.Padding(4);
            this.pEstado.Name = "pEstado";
            this.pEstado.Size = new System.Drawing.Size(679, 700);
            this.pEstado.TabIndex = 9;
            // 
            // lvwAbsences
            // 
            this.lvwAbsences.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chSubject,
            this.chState,
            this.chJustification});
            this.lvwAbsences.HideSelection = false;
            this.lvwAbsences.Location = new System.Drawing.Point(20, 158);
            this.lvwAbsences.Name = "lvwAbsences";
            this.lvwAbsences.Size = new System.Drawing.Size(642, 464);
            this.lvwAbsences.TabIndex = 12;
            this.lvwAbsences.UseCompatibleStateImageBehavior = false;
            this.lvwAbsences.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Data";
            this.chDate.Width = 130;
            // 
            // chSubject
            // 
            this.chSubject.Text = "Disciplina";
            this.chSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSubject.Width = 130;
            // 
            // chState
            // 
            this.chState.Text = "Estado";
            this.chState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chState.Width = 130;
            // 
            // chJustification
            // 
            this.chJustification.Text = "Justificação";
            this.chJustification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chJustification.Width = 130;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(15, 647);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(647, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(15, 629);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 5);
            this.panel4.TabIndex = 11;
            // 
            // FormAbsencesStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.pEstado);
            this.Controls.Add(this.pDescricao);
            this.Controls.Add(this.lblJustification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbsencesStudent";
            this.Text = "FormAbsencesStudent";
            this.Load += new System.EventHandler(this.FormAbsencesStudent_Load);
            this.grbAbsenceState.ResumeLayout(false);
            this.grbAbsenceState.PerformLayout();
            this.pDescricao.ResumeLayout(false);
            this.pDescricao.PerformLayout();
            this.pEstado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJustification;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.GroupBox grbAbsenceState;
        private System.Windows.Forms.RadioButton rbAllAbsences;
        private System.Windows.Forms.RadioButton rbUnjustified;
        private System.Windows.Forms.RadioButton rbJustified;
        private System.Windows.Forms.Panel pCorUsername;
        private System.Windows.Forms.Panel pDescricao;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pEstado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvwAbsences;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chSubject;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chJustification;
    }
}