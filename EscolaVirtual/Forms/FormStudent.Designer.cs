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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSchoolCard = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tvwGradesAndAverage = new System.Windows.Forms.TreeView();
            this.pcolorbutton = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcolorbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(9, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(113, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem Vindo";
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Green;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnData.Location = new System.Drawing.Point(308, 13);
            this.btnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(139, 53);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Alterar Dados";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(19, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.BackColor = System.Drawing.Color.Green;
            this.btnAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbsence.Location = new System.Drawing.Point(784, 13);
            this.btnAbsence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(139, 53);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Consultar Faltas e Estado";
            this.btnAbsence.UseVisualStyleBackColor = false;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnSchoolCard
            // 
            this.btnSchoolCard.BackColor = System.Drawing.Color.Green;
            this.btnSchoolCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoolCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSchoolCard.Location = new System.Drawing.Point(625, 13);
            this.btnSchoolCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchoolCard.Name = "btnSchoolCard";
            this.btnSchoolCard.Size = new System.Drawing.Size(139, 53);
            this.btnSchoolCard.TabIndex = 4;
            this.btnSchoolCard.Text = "Cartão da Escola";
            this.btnSchoolCard.UseVisualStyleBackColor = false;
            this.btnSchoolCard.Click += new System.EventHandler(this.btnSchoolCard_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Green;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMessages.Location = new System.Drawing.Point(464, 13);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(139, 53);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Mensagens";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(663, 7);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(123, 24);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Média Geral";
            // 
            // tvwGradesAndAverage
            // 
            this.tvwGradesAndAverage.Location = new System.Drawing.Point(9, 46);
            this.tvwGradesAndAverage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvwGradesAndAverage.Name = "tvwGradesAndAverage";
            this.tvwGradesAndAverage.Size = new System.Drawing.Size(933, 496);
            this.tvwGradesAndAverage.TabIndex = 7;
            // 
            // pcolorbutton
            // 
            this.pcolorbutton.BackColor = System.Drawing.Color.Silver;
            this.pcolorbutton.Controls.Add(this.btnExit);
            this.pcolorbutton.Controls.Add(this.btnData);
            this.pcolorbutton.Controls.Add(this.btnMessages);
            this.pcolorbutton.Controls.Add(this.btnAbsence);
            this.pcolorbutton.Controls.Add(this.btnSchoolCard);
            this.pcolorbutton.Location = new System.Drawing.Point(9, 559);
            this.pcolorbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcolorbutton.Name = "pcolorbutton";
            this.pcolorbutton.Size = new System.Drawing.Size(932, 81);
            this.pcolorbutton.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(9, 538);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 3);
            this.panel1.TabIndex = 9;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcolorbutton);
            this.Controls.Add(this.tvwGradesAndAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormStudent";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudent_FormClosed);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.pcolorbutton.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pcolorbutton;
        private System.Windows.Forms.Panel panel1;
    }
}