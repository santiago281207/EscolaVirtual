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
            this.lvMovementsHistory = new System.Windows.Forms.ListView();
            this.lblMovementsHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(26, 32);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(105, 24);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Saldo Atual";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(124, 539);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.MaxLength = 5;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(23, 581);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(140, 46);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Efetuar Depósito";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(781, 581);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(23, 533);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(99, 24);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Depósito : ";
            // 
            // lvMovementsHistory
            // 
            this.lvMovementsHistory.HideSelection = false;
            this.lvMovementsHistory.Location = new System.Drawing.Point(23, 115);
            this.lvMovementsHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvMovementsHistory.Name = "lvMovementsHistory";
            this.lvMovementsHistory.Size = new System.Drawing.Size(899, 377);
            this.lvMovementsHistory.TabIndex = 5;
            this.lvMovementsHistory.UseCompatibleStateImageBehavior = false;
            this.lvMovementsHistory.View = System.Windows.Forms.View.Details;
            // 
            // lblMovementsHistory
            // 
            this.lblMovementsHistory.AutoSize = true;
            this.lblMovementsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovementsHistory.Location = new System.Drawing.Point(33, 124);
            this.lblMovementsHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovementsHistory.Name = "lblMovementsHistory";
            this.lblMovementsHistory.Size = new System.Drawing.Size(217, 24);
            this.lblMovementsHistory.TabIndex = 6;
            this.lblMovementsHistory.Text = "Histórico de Movimentos";
            // 
            // FormSchoolCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.lblMovementsHistory);
            this.Controls.Add(this.lvMovementsHistory);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormSchoolCard";
            this.Text = "Cartão da Escola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ListView lvMovementsHistory;
        private System.Windows.Forms.Label lblMovementsHistory;
    }
}