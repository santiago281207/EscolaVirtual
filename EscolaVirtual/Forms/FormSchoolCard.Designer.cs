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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lvwMovementsHistory = new System.Windows.Forms.ListView();
            this.chMovementType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMovementDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultingBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbTransactionType = new System.Windows.Forms.GroupBox();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.grbSortBy = new System.Windows.Forms.GroupBox();
            this.rdbDontSort = new System.Windows.Forms.RadioButton();
            this.rdbSortDeposit = new System.Windows.Forms.RadioButton();
            this.rdbSortWithdraw = new System.Windows.Forms.RadioButton();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.grbTransactionType.SuspendLayout();
            this.grbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
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
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Green;
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(20, 510);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 24);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Quantia :";
            // 
            // lvwMovementsHistory
            // 
            this.lvwMovementsHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMovementType,
            this.chMovementDate,
            this.chAmount,
            this.chResultingBalance});
            this.lvwMovementsHistory.HideSelection = false;
            this.lvwMovementsHistory.Location = new System.Drawing.Point(23, 52);
            this.lvwMovementsHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lvwMovementsHistory.MultiSelect = false;
            this.lvwMovementsHistory.Name = "lvwMovementsHistory";
            this.lvwMovementsHistory.Size = new System.Drawing.Size(899, 442);
            this.lvwMovementsHistory.TabIndex = 5;
            this.lvwMovementsHistory.UseCompatibleStateImageBehavior = false;
            this.lvwMovementsHistory.View = System.Windows.Forms.View.Details;
            // 
            // chMovementType
            // 
            this.chMovementType.Text = "Tipo de Movimento";
            this.chMovementType.Width = 130;
            // 
            // chMovementDate
            // 
            this.chMovementDate.Text = "Data do Movimento";
            this.chMovementDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMovementDate.Width = 140;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Quantia";
            this.chAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAmount.Width = 100;
            // 
            // chResultingBalance
            // 
            this.chResultingBalance.Text = "Saldo Resultante";
            this.chResultingBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chResultingBalance.Width = 130;
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
            this.grbTransactionType.Location = new System.Drawing.Point(287, 498);
            this.grbTransactionType.Name = "grbTransactionType";
            this.grbTransactionType.Size = new System.Drawing.Size(258, 48);
            this.grbTransactionType.TabIndex = 10;
            this.grbTransactionType.TabStop = false;
            this.grbTransactionType.Text = "Tipo";
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Checked = true;
            this.rbDeposit.Location = new System.Drawing.Point(152, 17);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(67, 17);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Depósito";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(18, 19);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(93, 17);
            this.rbWithdraw.TabIndex = 0;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Levantamento";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // grbSortBy
            // 
            this.grbSortBy.Controls.Add(this.rdbDontSort);
            this.grbSortBy.Controls.Add(this.rdbSortDeposit);
            this.grbSortBy.Controls.Add(this.rdbSortWithdraw);
            this.grbSortBy.Location = new System.Drawing.Point(602, 498);
            this.grbSortBy.Name = "grbSortBy";
            this.grbSortBy.Size = new System.Drawing.Size(320, 48);
            this.grbSortBy.TabIndex = 11;
            this.grbSortBy.TabStop = false;
            this.grbSortBy.Text = "Ordenar por tipo";
            // 
            // rdbDontSort
            // 
            this.rdbDontSort.AutoSize = true;
            this.rdbDontSort.Checked = true;
            this.rdbDontSort.Location = new System.Drawing.Point(247, 17);
            this.rdbDontSort.Name = "rdbDontSort";
            this.rdbDontSort.Size = new System.Drawing.Size(65, 17);
            this.rdbDontSort.TabIndex = 2;
            this.rdbDontSort.TabStop = true;
            this.rdbDontSort.Text = "Nenhum";
            this.rdbDontSort.UseVisualStyleBackColor = true;
            this.rdbDontSort.CheckedChanged += new System.EventHandler(this.rdbDontSort_CheckedChanged);
            // 
            // rdbSortDeposit
            // 
            this.rdbSortDeposit.AutoSize = true;
            this.rdbSortDeposit.Location = new System.Drawing.Point(152, 17);
            this.rdbSortDeposit.Name = "rdbSortDeposit";
            this.rdbSortDeposit.Size = new System.Drawing.Size(67, 17);
            this.rdbSortDeposit.TabIndex = 1;
            this.rdbSortDeposit.Text = "Depósito";
            this.rdbSortDeposit.UseVisualStyleBackColor = true;
            this.rdbSortDeposit.CheckedChanged += new System.EventHandler(this.rdbSortDeposit_CheckedChanged);
            // 
            // rdbSortWithdraw
            // 
            this.rdbSortWithdraw.AutoSize = true;
            this.rdbSortWithdraw.Location = new System.Drawing.Point(18, 19);
            this.rdbSortWithdraw.Name = "rdbSortWithdraw";
            this.rdbSortWithdraw.Size = new System.Drawing.Size(93, 17);
            this.rdbSortWithdraw.TabIndex = 0;
            this.rdbSortWithdraw.Text = "Levantamento";
            this.rdbSortWithdraw.UseVisualStyleBackColor = true;
            this.rdbSortWithdraw.CheckedChanged += new System.EventHandler(this.rdbSortWithdraw_CheckedChanged);
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAmount.Location = new System.Drawing.Point(113, 514);
            this.nudAmount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAmount.TabIndex = 3;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormSchoolCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.grbSortBy);
            this.Controls.Add(this.grbTransactionType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMovementsHistory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormSchoolCard";
            this.Text = "Cartão da Escola";
            this.Load += new System.EventHandler(this.FormSchoolCard_Load);
            this.panel1.ResumeLayout(false);
            this.grbTransactionType.ResumeLayout(false);
            this.grbTransactionType.PerformLayout();
            this.grbSortBy.ResumeLayout(false);
            this.grbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ListView lvwMovementsHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbTransactionType;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.ColumnHeader chMovementType;
        private System.Windows.Forms.ColumnHeader chMovementDate;
        private System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.ColumnHeader chResultingBalance;
        private System.Windows.Forms.GroupBox grbSortBy;
        private System.Windows.Forms.RadioButton rdbSortDeposit;
        private System.Windows.Forms.RadioButton rdbSortWithdraw;
        private System.Windows.Forms.RadioButton rdbDontSort;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}