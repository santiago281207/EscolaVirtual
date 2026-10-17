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
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pnlCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClassYear
            // 
            this.lblClassYear.AutoSize = true;
            this.lblClassYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassYear.Location = new System.Drawing.Point(99, 67);
            this.lblClassYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(121, 18);
            this.lblClassYear.TabIndex = 0;
            this.lblClassYear.Text = "Ano da Disciplina";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(99, 148);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(136, 18);
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "Nome da Disciplina";
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.Color.Green;
            this.btnCreateSubject.Enabled = false;
            this.btnCreateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.ForeColor = System.Drawing.Color.White;
            this.btnCreateSubject.Location = new System.Drawing.Point(92, 233);
            this.btnCreateSubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(133, 36);
            this.btnCreateSubject.TabIndex = 3;
            this.btnCreateSubject.Text = "Criar Disciplina";
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(259, 233);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cbClassYear
            // 
            this.cbClassYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Items.AddRange(new object[] {
            "10º Ano",
            "11ª Ano"});
            this.cbClassYear.Location = new System.Drawing.Point(92, 96);
            this.cbClassYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(300, 21);
            this.cbClassYear.TabIndex = 5;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(92, 178);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(300, 20);
            this.txtSubjectName.TabIndex = 6;
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.White;
            this.pnlCreate.Controls.Add(this.btnCreateSubject);
            this.pnlCreate.Controls.Add(this.btnExit);
            this.pnlCreate.Controls.Add(this.cbClassYear);
            this.pnlCreate.Controls.Add(this.txtSubjectName);
            this.pnlCreate.Controls.Add(this.lblClassYear);
            this.pnlCreate.Controls.Add(this.lblSubjectName);
            this.pnlCreate.Location = new System.Drawing.Point(90, 0);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(508, 334);
            this.pnlCreate.TabIndex = 7;
            // 
            // FormCreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(689, 334);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCreateSubject";
            this.Text = "Criar Disciplina";
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClassYear;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbClassYear;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Panel pnlCreate;
    }
}