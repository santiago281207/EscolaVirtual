namespace EscolaVirtual
{
    partial class FormStudent
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSchoolCard = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tvwGradesAndAverage = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(25, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(140, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem Vindo";
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(29, 266);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(276, 73);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Alterar Dados";
            this.btnData.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(29, 699);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(276, 73);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsence.Location = new System.Drawing.Point(29, 140);
            this.btnAbsence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(276, 73);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Consultar Faltas e Estado";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnSchoolCard
            // 
            this.btnSchoolCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoolCard.Location = new System.Drawing.Point(29, 399);
            this.btnSchoolCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSchoolCard.Name = "btnSchoolCard";
            this.btnSchoolCard.Size = new System.Drawing.Size(276, 73);
            this.btnSchoolCard.TabIndex = 4;
            this.btnSchoolCard.Text = "Cartão da Escola";
            this.btnSchoolCard.UseVisualStyleBackColor = true;
            // 
            // btnMessages
            // 
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.Location = new System.Drawing.Point(29, 529);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(276, 73);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Mensagens";
            this.btnMessages.UseVisualStyleBackColor = true;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(549, 81);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(156, 29);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Média Geral";
            // 
            // tvwGradesAndAverage
            // 
            this.tvwGradesAndAverage.Location = new System.Drawing.Point(555, 140);
            this.tvwGradesAndAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvwGradesAndAverage.Name = "tvwGradesAndAverage";
            this.tvwGradesAndAverage.Size = new System.Drawing.Size(672, 632);
            this.tvwGradesAndAverage.TabIndex = 7;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.tvwGradesAndAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnSchoolCard);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnSchoolCard;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TreeView tvwGradesAndAverage;
    }
}