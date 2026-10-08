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
            this.tvwAVG = new System.Windows.Forms.TreeView();
            this.tvwSubjectClass = new System.Windows.Forms.TreeView();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblSubjectClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvwAVG
            // 
            this.tvwAVG.Location = new System.Drawing.Point(170, 89);
            this.tvwAVG.Name = "tvwAVG";
            this.tvwAVG.Size = new System.Drawing.Size(373, 484);
            this.tvwAVG.TabIndex = 0;
            // 
            // tvwSubjectClass
            // 
            this.tvwSubjectClass.Location = new System.Drawing.Point(565, 89);
            this.tvwSubjectClass.Name = "tvwSubjectClass";
            this.tvwSubjectClass.Size = new System.Drawing.Size(373, 484);
            this.tvwSubjectClass.TabIndex = 1;
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(12, 89);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(139, 53);
            this.btnGrades.TabIndex = 2;
            this.btnGrades.Text = "Notas";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(12, 148);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(139, 53);
            this.btnAbsences.TabIndex = 3;
            this.btnAbsences.Text = "Faltas";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnChangeData
            // 
            this.btnChangeData.Location = new System.Drawing.Point(12, 207);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(139, 53);
            this.btnChangeData.TabIndex = 4;
            this.btnChangeData.Text = "Alterar Dados";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(12, 266);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(139, 53);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Mensagens";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(799, 585);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(139, 53);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 24);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "label1";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(167, 73);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(240, 13);
            this.lblAvg.TabIndex = 8;
            this.lblAvg.Text = "Consultar média da turma e resultados dos alunos";
            // 
            // lblSubjectClass
            // 
            this.lblSubjectClass.AutoSize = true;
            this.lblSubjectClass.Location = new System.Drawing.Point(562, 73);
            this.lblSubjectClass.Name = "lblSubjectClass";
            this.lblSubjectClass.Size = new System.Drawing.Size(140, 13);
            this.lblSubjectClass.TabIndex = 9;
            this.lblSubjectClass.Text = "Consultar turma e disciplinas";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.lblSubjectClass);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.tvwSubjectClass);
            this.Controls.Add(this.tvwAVG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwAVG;
        private System.Windows.Forms.TreeView tvwSubjectClass;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblSubjectClass;
    }
}