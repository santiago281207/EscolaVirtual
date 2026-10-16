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
            this.lblClassYear.Location = new System.Drawing.Point(132, 82);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(156, 24);
            this.lblClassYear.TabIndex = 0;
            this.lblClassYear.Text = "Ano da Disciplina";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(132, 182);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(173, 24);
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
            this.btnCreateSubject.Location = new System.Drawing.Point(345, 288);
            this.btnCreateSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(177, 44);
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
            this.btnExit.Location = new System.Drawing.Point(123, 288);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbClassYear
            // 
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Items.AddRange(new object[] {
            "10º Ano",
            "11ª Ano"});
            this.cbClassYear.Location = new System.Drawing.Point(123, 118);
            this.cbClassYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(399, 24);
            this.cbClassYear.TabIndex = 5;
            this.cbClassYear.SelectedIndexChanged += new System.EventHandler(this.cbClassYear_SelectedIndexChanged);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(123, 219);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(399, 22);
            this.txtSubjectName.TabIndex = 6;
            this.txtSubjectName.TextChanged += new System.EventHandler(this.txtSubjectName_TextChanged);
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
            this.pnlCreate.Location = new System.Drawing.Point(120, 0);
            this.pnlCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(677, 411);
            this.pnlCreate.TabIndex = 7;
            // 
            // FormCreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(919, 411);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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