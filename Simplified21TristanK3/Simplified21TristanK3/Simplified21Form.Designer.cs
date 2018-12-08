namespace Simplified21TristanK3
{
    partial class frmSimplified21
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
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.txtPlayerCard1 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard2 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard3 = new System.Windows.Forms.TextBox();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.txtDealerCard1 = new System.Windows.Forms.TextBox();
            this.txtDealerCard3 = new System.Windows.Forms.TextBox();
            this.txtDealerCard2 = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(247, 24);
            this.mnuOptions.TabIndex = 0;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Location = new System.Drawing.Point(21, 46);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(62, 13);
            this.lblPlayerCards.TabIndex = 1;
            this.lblPlayerCards.Text = "Your Cards:";
            // 
            // txtPlayerCard1
            // 
            this.txtPlayerCard1.Enabled = false;
            this.txtPlayerCard1.Location = new System.Drawing.Point(24, 74);
            this.txtPlayerCard1.Name = "txtPlayerCard1";
            this.txtPlayerCard1.ReadOnly = true;
            this.txtPlayerCard1.Size = new System.Drawing.Size(40, 20);
            this.txtPlayerCard1.TabIndex = 2;
            // 
            // txtPlayerCard2
            // 
            this.txtPlayerCard2.Enabled = false;
            this.txtPlayerCard2.Location = new System.Drawing.Point(70, 74);
            this.txtPlayerCard2.Name = "txtPlayerCard2";
            this.txtPlayerCard2.ReadOnly = true;
            this.txtPlayerCard2.Size = new System.Drawing.Size(39, 20);
            this.txtPlayerCard2.TabIndex = 3;
            // 
            // txtPlayerCard3
            // 
            this.txtPlayerCard3.Enabled = false;
            this.txtPlayerCard3.Location = new System.Drawing.Point(115, 74);
            this.txtPlayerCard3.Name = "txtPlayerCard3";
            this.txtPlayerCard3.ReadOnly = true;
            this.txtPlayerCard3.Size = new System.Drawing.Size(39, 20);
            this.txtPlayerCard3.TabIndex = 4;
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Location = new System.Drawing.Point(21, 122);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(78, 13);
            this.lblDealerCards.TabIndex = 5;
            this.lblDealerCards.Text = "Dealer\'s Cards:";
            // 
            // txtDealerCard1
            // 
            this.txtDealerCard1.Enabled = false;
            this.txtDealerCard1.Location = new System.Drawing.Point(24, 149);
            this.txtDealerCard1.Name = "txtDealerCard1";
            this.txtDealerCard1.ReadOnly = true;
            this.txtDealerCard1.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard1.TabIndex = 6;
            // 
            // txtDealerCard3
            // 
            this.txtDealerCard3.Enabled = false;
            this.txtDealerCard3.Location = new System.Drawing.Point(114, 149);
            this.txtDealerCard3.Name = "txtDealerCard3";
            this.txtDealerCard3.ReadOnly = true;
            this.txtDealerCard3.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard3.TabIndex = 7;
            // 
            // txtDealerCard2
            // 
            this.txtDealerCard2.Enabled = false;
            this.txtDealerCard2.Location = new System.Drawing.Point(70, 149);
            this.txtDealerCard2.Name = "txtDealerCard2";
            this.txtDealerCard2.ReadOnly = true;
            this.txtDealerCard2.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard2.TabIndex = 8;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(89, 41);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(54, 23);
            this.btnHit.TabIndex = 9;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(149, 41);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(54, 23);
            this.btnStay.TabIndex = 10;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(67, 215);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(74, 13);
            this.lblOutcome.TabIndex = 11;
            this.lblOutcome.Text = "The Winner Is";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 266);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.txtDealerCard2);
            this.Controls.Add(this.txtDealerCard3);
            this.Controls.Add(this.txtDealerCard1);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.txtPlayerCard3);
            this.Controls.Add(this.txtPlayerCard2);
            this.Controls.Add(this.txtPlayerCard1);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.mnuOptions);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21";
            this.Load += new System.EventHandler(this.frmSimplified21_Load);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.TextBox txtPlayerCard1;
        private System.Windows.Forms.TextBox txtPlayerCard2;
        private System.Windows.Forms.TextBox txtPlayerCard3;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.TextBox txtDealerCard1;
        private System.Windows.Forms.TextBox txtDealerCard3;
        private System.Windows.Forms.TextBox txtDealerCard2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblOutcome;
    }
}

