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
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassYear = new System.Windows.Forms.Label();
            this.cbClassYear = new System.Windows.Forms.ComboBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
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
            this.pCreate.Location = new System.Drawing.Point(191, -1);
            this.pCreate.Name = "pCreate";
            this.pCreate.Size = new System.Drawing.Size(605, 376);
            this.pCreate.TabIndex = 0;
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.BackColor = System.Drawing.Color.Green;
            this.btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.ForeColor = System.Drawing.Color.White;
            this.btnCreateClass.Location = new System.Drawing.Point(57, 270);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(159, 57);
            this.btnCreateClass.TabIndex = 0;
            this.btnCreateClass.Text = "Criar Turma";
            this.btnCreateClass.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(379, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 57);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(54, 165);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(105, 16);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Nome da Turma";
            // 
            // lblClassYear
            // 
            this.lblClassYear.AutoSize = true;
            this.lblClassYear.Location = new System.Drawing.Point(54, 72);
            this.lblClassYear.Name = "lblClassYear";
            this.lblClassYear.Size = new System.Drawing.Size(92, 16);
            this.lblClassYear.TabIndex = 3;
            this.lblClassYear.Text = "Ano da Turma";
            // 
            // cbClassYear
            // 
            this.cbClassYear.FormattingEnabled = true;
            this.cbClassYear.Location = new System.Drawing.Point(57, 91);
            this.cbClassYear.Name = "cbClassYear";
            this.cbClassYear.Size = new System.Drawing.Size(481, 24);
            this.cbClassYear.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(57, 184);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(481, 22);
            this.txtClassName.TabIndex = 5;
            // 
            // FormCreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1002, 375);
            this.Controls.Add(this.pCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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