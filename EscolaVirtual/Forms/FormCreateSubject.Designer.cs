namespace EscolaVirtual.Forms
{
    partial class FormCreateSubject
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
            this.lblClassYear = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbClassYear = new System.Windows.Forms.ComboBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClassYear
            // 
            this.lblClassYear.AutoSize = true;
            this.lblClassYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassYear.Location = new System.Drawing.Point(471, 202);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(199, 29);
            this.lblClassYear.TabIndex = 0;
            this.lblClassYear.Text = "Ano da Disciplina";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(471, 352);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(223, 29);
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "Nome da Disciplina";
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.Location = new System.Drawing.Point(492, 506);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(202, 62);
            this.btnCreateSubject.TabIndex = 3;
            this.btnCreateSubject.Text = "Criar Disciplina";
            this.btnCreateSubject.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(492, 652);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cbClassYear
            // 
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Items.AddRange(new object[] {
            "10º Ano",
            "11ª Ano"});
            this.cbClassYear.Location = new System.Drawing.Point(476, 262);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(194, 24);
            this.cbClassYear.TabIndex = 5;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(418, 407);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(352, 22);
            this.txtSubjectName.TabIndex = 6;
            // 
            // FormCreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.cbClassYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateSubject);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblClassYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateSubject";
            this.Text = "Criar Disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassYear;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbClassYear;
        private System.Windows.Forms.TextBox txtSubjectName;
    }
}