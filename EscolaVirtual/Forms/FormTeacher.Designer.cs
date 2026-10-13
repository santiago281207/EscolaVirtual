namespace EscolaVirtual
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.tvwSubjectClass = new System.Windows.Forms.TreeView();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pFormTeacher = new System.Windows.Forms.Panel();
            this.pcolor = new System.Windows.Forms.Panel();
            this.pFormTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwSubjectClass
            // 
            this.tvwSubjectClass.Location = new System.Drawing.Point(4, 4);
            this.tvwSubjectClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvwSubjectClass.Name = "tvwSubjectClass";
            this.tvwSubjectClass.Size = new System.Drawing.Size(1204, 596);
            this.tvwSubjectClass.TabIndex = 1;
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.Green;
            this.btnGrades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrades.Location = new System.Drawing.Point(14, 640);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(185, 65);
            this.btnGrades.TabIndex = 2;
            this.btnGrades.Text = "Notas";
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.Color.Green;
            this.btnAbsences.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbsences.Location = new System.Drawing.Point(242, 640);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(185, 65);
            this.btnAbsences.TabIndex = 3;
            this.btnAbsences.Text = "Faltas";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackColor = System.Drawing.Color.Green;
            this.btnChangeData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeData.Location = new System.Drawing.Point(464, 640);
            this.btnChangeData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(185, 65);
            this.btnChangeData.TabIndex = 4;
            this.btnChangeData.Text = "Alterar Dados";
            this.btnChangeData.UseVisualStyleBackColor = false;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Green;
            this.btnMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMessages.Location = new System.Drawing.Point(688, 640);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(185, 65);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Mensagens";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(1009, 640);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(185, 65);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(85, 29);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "label1";
            // 
            // pFormTeacher
            // 
            this.pFormTeacher.BackColor = System.Drawing.Color.Silver;
            this.pFormTeacher.Controls.Add(this.pcolor);
            this.pFormTeacher.Controls.Add(this.btnLogOut);
            this.pFormTeacher.Controls.Add(this.tvwSubjectClass);
            this.pFormTeacher.Controls.Add(this.btnMessages);
            this.pFormTeacher.Controls.Add(this.btnGrades);
            this.pFormTeacher.Controls.Add(this.btnAbsences);
            this.pFormTeacher.Controls.Add(this.btnChangeData);
            this.pFormTeacher.Location = new System.Drawing.Point(27, 52);
            this.pFormTeacher.Name = "pFormTeacher";
            this.pFormTeacher.Size = new System.Drawing.Size(1212, 736);
            this.pFormTeacher.TabIndex = 8;
            // 
            // pcolor
            // 
            this.pcolor.BackColor = System.Drawing.Color.Green;
            this.pcolor.Location = new System.Drawing.Point(4, 596);
            this.pcolor.Name = "pcolor";
            this.pcolor.Size = new System.Drawing.Size(1203, 4);
            this.pcolor.TabIndex = 9;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.pFormTeacher);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.pFormTeacher.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvwSubjectClass;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pFormTeacher;
        private System.Windows.Forms.Panel pcolor;
    }
}