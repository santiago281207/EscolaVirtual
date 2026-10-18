namespace EscolaVirtual.Forms
{
    partial class FormSchoolCard
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lvwMovementsHistory = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbTransactionType = new System.Windows.Forms.GroupBox();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.grbTransactionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(9, 15);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(105, 24);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Saldo Atual";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(120, 516);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.MaxLength = 5;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Green;
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(14, 18);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(140, 46);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Efetuar Depósito";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(758, 18);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(20, 510);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(99, 24);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Depósito : ";
            // 
            // lvwMovementsHistory
            // 
            this.lvwMovementsHistory.HideSelection = false;
            this.lvwMovementsHistory.Location = new System.Drawing.Point(23, 52);
            this.lvwMovementsHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lvwMovementsHistory.Name = "lvwMovementsHistory";
            this.lvwMovementsHistory.Size = new System.Drawing.Size(899, 442);
            this.lvwMovementsHistory.TabIndex = 5;
            this.lvwMovementsHistory.UseCompatibleStateImageBehavior = false;
            this.lvwMovementsHistory.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnDeposit);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(23, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 81);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(23, 490);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 3);
            this.panel2.TabIndex = 8;
            // 
            // grbTransactionType
            // 
            this.grbTransactionType.Controls.Add(this.rbDeposit);
            this.grbTransactionType.Controls.Add(this.rbWithdraw);
            this.grbTransactionType.Location = new System.Drawing.Point(287, 510);
            this.grbTransactionType.Name = "grbTransactionType";
            this.grbTransactionType.Size = new System.Drawing.Size(258, 36);
            this.grbTransactionType.TabIndex = 10;
            this.grbTransactionType.TabStop = false;
            this.grbTransactionType.Text = "Tipo";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(6, 13);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(93, 17);
            this.rbWithdraw.TabIndex = 0;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Levantamento";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(153, 13);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(67, 17);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Depósito";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // FormSchoolCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.grbTransactionType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMovementsHistory);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormSchoolCard";
            this.Text = "Cartão da Escola";
            this.panel1.ResumeLayout(false);
            this.grbTransactionType.ResumeLayout(false);
            this.grbTransactionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ListView lvwMovementsHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbTransactionType;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
    }
}