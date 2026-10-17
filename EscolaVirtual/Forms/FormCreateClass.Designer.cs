namespace EscolaVirtual.Forms
{
    partial class FormCreateClass
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
            this.pCreate = new System.Windows.Forms.Panel();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cbClassYear = new System.Windows.Forms.ComboBox();
            this.lblClassYear = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.pCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCreate
            // 
            this.pCreate.BackColor = System.Drawing.Color.White;
            this.pCreate.Controls.Add(this.txtClassName);
            this.pCreate.Controls.Add(this.cbClassYear);
            this.pCreate.Controls.Add(this.lblClassYear);
            this.pCreate.Controls.Add(this.lblClassName);
            this.pCreate.Controls.Add(this.btnExit);
            this.pCreate.Controls.Add(this.btnCreateClass);
            this.pCreate.Location = new System.Drawing.Point(143, -1);
            this.pCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCreate.Name = "pCreate";
            this.pCreate.Size = new System.Drawing.Size(454, 306);
            this.pCreate.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(43, 150);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassName.MaxLength = 20;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(362, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // cbClassYear
            // 
            this.cbClassYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Location = new System.Drawing.Point(43, 74);
            this.cbClassYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(362, 21);
            this.cbClassYear.TabIndex = 4;
            // 
            // lblClassYear
            // 
            this.lblClassYear.AutoSize = true;
            this.lblClassYear.Location = new System.Drawing.Point(40, 58);
            this.lblClassYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(74, 13);
            this.lblClassYear.TabIndex = 3;
            this.lblClassYear.Text = "Ano da Turma";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(40, 134);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(83, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Nome da Turma";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(284, 219);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.BackColor = System.Drawing.Color.Green;
            this.btnCreateClass.Enabled = false;
            this.btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.ForeColor = System.Drawing.Color.White;
            this.btnCreateClass.Location = new System.Drawing.Point(43, 219);
            this.btnCreateClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(119, 46);
            this.btnCreateClass.TabIndex = 0;
            this.btnCreateClass.Text = "Criar Turma";
            this.btnCreateClass.UseVisualStyleBackColor = false;
            // 
            // FormCreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(752, 305);
            this.Controls.Add(this.pCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormCreateClass";
            this.Text = "Criar Turma";
            this.pCreate.ResumeLayout(false);
            this.pCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCreate;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox cbClassYear;
        private System.Windows.Forms.Label lblClassYear;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateClass;
    }
}