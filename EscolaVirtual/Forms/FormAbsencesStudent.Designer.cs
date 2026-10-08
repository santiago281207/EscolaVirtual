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
            this.tvwAbsences = new System.Windows.Forms.TreeView();
            this.lblJustification = new System.Windows.Forms.Label();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.btnJustification = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbAbsenceState = new System.Windows.Forms.GroupBox();
            this.rbAllAbsences = new System.Windows.Forms.RadioButton();
            this.rbUnjustified = new System.Windows.Forms.RadioButton();
            this.rbJustified = new System.Windows.Forms.RadioButton();
            this.grbAbsenceState.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwAbsences
            // 
            this.tvwAbsences.Location = new System.Drawing.Point(629, 196);
            this.tvwAbsences.Name = "tvwAbsences";
            this.tvwAbsences.Size = new System.Drawing.Size(615, 472);
            this.tvwAbsences.TabIndex = 1;
            // 
            // lblJustification
            // 
            this.lblJustification.AutoSize = true;
            this.lblJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustification.Location = new System.Drawing.Point(28, 38);
            this.lblJustification.Name = "lblJustification";
            this.lblJustification.Size = new System.Drawing.Size(231, 29);
            this.lblJustification.TabIndex = 2;
            this.lblJustification.Text = "Justificação de Falta";
            // 
            // txtJustification
            // 
            this.txtJustification.Location = new System.Drawing.Point(33, 101);
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(342, 22);
            this.txtJustification.TabIndex = 3;
            // 
            // btnJustification
            // 
            this.btnJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustification.Location = new System.Drawing.Point(33, 697);
            this.btnJustification.Name = "btnJustification";
            this.btnJustification.Size = new System.Drawing.Size(226, 71);
            this.btnJustification.TabIndex = 4;
            this.btnJustification.Text = "Submeter Justificação";
            this.btnJustification.UseVisualStyleBackColor = true;
            this.btnJustification.Click += new System.EventHandler(this.btnJustification_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1018, 697);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 71);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Voltar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbAbsenceState
            // 
            this.grbAbsenceState.Controls.Add(this.rbAllAbsences);
            this.grbAbsenceState.Controls.Add(this.rbUnjustified);
            this.grbAbsenceState.Controls.Add(this.rbJustified);
            this.grbAbsenceState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbsenceState.Location = new System.Drawing.Point(629, 38);
            this.grbAbsenceState.Name = "grbAbsenceState";
            this.grbAbsenceState.Size = new System.Drawing.Size(239, 135);
            this.grbAbsenceState.TabIndex = 6;
            this.grbAbsenceState.TabStop = false;
            this.grbAbsenceState.Text = "Estado de Falta";
            // 
            // rbAllAbsences
            // 
            this.rbAllAbsences.AutoSize = true;
            this.rbAllAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllAbsences.Location = new System.Drawing.Point(6, 98);
            this.rbAllAbsences.Name = "rbAllAbsences";
            this.rbAllAbsences.Size = new System.Drawing.Size(160, 26);
            this.rbAllAbsences.TabIndex = 7;
            this.rbAllAbsences.TabStop = true;
            this.rbAllAbsences.Text = "Todas as Faltas";
            this.rbAllAbsences.UseVisualStyleBackColor = true;
            // 
            // rbUnjustified
            // 
            this.rbUnjustified.AutoSize = true;
            this.rbUnjustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnjustified.Location = new System.Drawing.Point(6, 63);
            this.rbUnjustified.Name = "rbUnjustified";
            this.rbUnjustified.Size = new System.Drawing.Size(125, 26);
            this.rbUnjustified.TabIndex = 8;
            this.rbUnjustified.TabStop = true;
            this.rbUnjustified.Text = "Injustificada";
            this.rbUnjustified.UseVisualStyleBackColor = true;
            // 
            // rbJustified
            // 
            this.rbJustified.AutoSize = true;
            this.rbJustified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJustified.Location = new System.Drawing.Point(6, 29);
            this.rbJustified.Name = "rbJustified";
            this.rbJustified.Size = new System.Drawing.Size(116, 26);
            this.rbJustified.TabIndex = 9;
            this.rbJustified.TabStop = true;
            this.rbJustified.Text = "Justificada";
            this.rbJustified.UseVisualStyleBackColor = true;
            // 
            // FormAbsencesStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.grbAbsenceState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJustification);
            this.Controls.Add(this.txtJustification);
            this.Controls.Add(this.lblJustification);
            this.Controls.Add(this.tvwAbsences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbsencesStudent";
            this.Text = "FormAbsencesStudent";
            this.grbAbsenceState.ResumeLayout(false);
            this.grbAbsenceState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvwAbsences;
        private System.Windows.Forms.Label lblJustification;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Button btnJustification;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbAbsenceState;
        private System.Windows.Forms.RadioButton rbAllAbsences;
        private System.Windows.Forms.RadioButton rbUnjustified;
        private System.Windows.Forms.RadioButton rbJustified;
    }
}