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
            this.tvwAbsences = new System.Windows.Forms.TreeView();
            this.lblJustification = new System.Windows.Forms.Label();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.grbAbsenceState = new System.Windows.Forms.GroupBox();
            this.rbAllAbsences = new System.Windows.Forms.RadioButton();
            this.rbUnjustified = new System.Windows.Forms.RadioButton();
            this.rbJustified = new System.Windows.Forms.RadioButton();
            this.pCorUsername = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbAbsenceState.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwAbsences
            // 
            this.tvwAbsences.Location = new System.Drawing.Point(11, 127);
            this.tvwAbsences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvwAbsences.Name = "tvwAbsences";
            this.tvwAbsences.Size = new System.Drawing.Size(485, 384);
            this.tvwAbsences.TabIndex = 1;
            this.tvwAbsences.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwAbsences_AfterSelect);
            // 
            // lblJustification
            // 
            this.lblJustification.AutoSize = true;
            this.lblJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustification.Location = new System.Drawing.Point(21, 18);
            this.lblJustification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJustification.Name = "lblJustification";
            this.lblJustification.Size = new System.Drawing.Size(176, 20);
            this.lblJustification.TabIndex = 2;
            this.lblJustification.Text = "Justificação de Falta";
            // 
            // txtJustification
            // 
            this.txtJustification.Location = new System.Drawing.Point(12, 34);
            this.txtJustification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(319, 477);
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
            this.grbAbsenceState.Location = new System.Drawing.Point(11, 11);
            this.grbAbsenceState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAbsenceState.Name = "grbAbsenceState";
            this.grbAbsenceState.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAbsenceState.Size = new System.Drawing.Size(485, 110);
            this.grbAbsenceState.TabIndex = 6;
            this.grbAbsenceState.TabStop = false;
            this.grbAbsenceState.Text = "Estado de Falta";
            // 
            // rbAllAbsences
            // 
            this.rbAllAbsences.AutoSize = true;
            this.rbAllAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllAbsences.Location = new System.Drawing.Point(4, 80);
            this.rbAllAbsences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAllAbsences.Name = "rbAllAbsences";
            this.rbAllAbsences.Size = new System.Drawing.Size(132, 22);
            this.rbAllAbsences.TabIndex = 7;
            this.rbAllAbsences.TabStop = true;
            this.rbAllAbsences.Text = "Todas as Faltas";
            this.rbAllAbsences.UseVisualStyleBackColor = true;
            // 
            // rbUnjustified
            // 
            this.rbUnjustified.AutoSize = true;
            this.rbUnjustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnjustified.Location = new System.Drawing.Point(4, 51);
            this.rbUnjustified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUnjustified.Name = "rbUnjustified";
            this.rbUnjustified.Size = new System.Drawing.Size(102, 22);
            this.rbUnjustified.TabIndex = 8;
            this.rbUnjustified.TabStop = true;
            this.rbUnjustified.Text = "Injustificada";
            this.rbUnjustified.UseVisualStyleBackColor = true;
            // 
            // rbJustified
            // 
            this.rbJustified.AutoSize = true;
            this.rbJustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJustified.Location = new System.Drawing.Point(4, 24);
            this.rbJustified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJustified.Name = "rbJustified";
            this.rbJustified.Size = new System.Drawing.Size(96, 22);
            this.rbJustified.TabIndex = 9;
            this.rbJustified.TabStop = true;
            this.rbJustified.Text = "Justificada";
            this.rbJustified.UseVisualStyleBackColor = true;
            // 
            // pCorUsername
            // 
            this.pCorUsername.BackColor = System.Drawing.Color.Green;
            this.pCorUsername.Location = new System.Drawing.Point(13, 511);
            this.pCorUsername.Name = "pCorUsername";
            this.pCorUsername.Size = new System.Drawing.Size(318, 4);
            this.pCorUsername.TabIndex = 7;
            this.pCorUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.pCorUsername_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtJustification);
            this.panel1.Controls.Add(this.pCorUsername);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(25, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 569);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(13, 11);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Descrição";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(12, 526);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(319, 30);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.grbAbsenceState);
            this.panel2.Controls.Add(this.tvwAbsences);
            this.panel2.Location = new System.Drawing.Point(410, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 569);
            this.panel2.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(11, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(485, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 4);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(11, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 4);
            this.panel4.TabIndex = 11;
            // 
            // FormAbsencesStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblJustification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbsencesStudent";
            this.Text = "FormAbsencesStudent";
            this.grbAbsenceState.ResumeLayout(false);
            this.grbAbsenceState.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvwAbsences;
        private System.Windows.Forms.Label lblJustification;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.GroupBox grbAbsenceState;
        private System.Windows.Forms.RadioButton rbAllAbsences;
        private System.Windows.Forms.RadioButton rbUnjustified;
        private System.Windows.Forms.RadioButton rbJustified;
        private System.Windows.Forms.Panel pCorUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
    }
}