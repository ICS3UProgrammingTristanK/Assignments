namespace Simplified21TristanK2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimplified21));
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.txtPlayerCard1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPlayerCard3 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard2 = new System.Windows.Forms.TextBox();
            this.txtDealerCard3 = new System.Windows.Forms.TextBox();
            this.txtDealerCard2 = new System.Windows.Forms.TextBox();
            this.txtDealerCard1 = new System.Windows.Forms.TextBox();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.mnuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(280, 24);
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
            // btnHit
            // 
            this.btnHit.Image = ((System.Drawing.Image)(resources.GetObject("btnHit.Image")));
            this.btnHit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHit.Location = new System.Drawing.Point(111, 52);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 7;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(192, 52);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 8;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(108, 210);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(77, 13);
            this.lblOutcome.TabIndex = 9;
            this.lblOutcome.Text = "The Winner Is:";
            // 
            // txtPlayerCard1
            // 
            this.txtPlayerCard1.Location = new System.Drawing.Point(16, 83);
            this.txtPlayerCard1.Name = "txtPlayerCard1";
            this.txtPlayerCard1.Size = new System.Drawing.Size(40, 20);
            this.txtPlayerCard1.TabIndex = 10;
            // 
            // txtPlayerCard3
            // 
            this.txtPlayerCard3.Location = new System.Drawing.Point(111, 84);
            this.txtPlayerCard3.Name = "txtPlayerCard3";
            this.txtPlayerCard3.Size = new System.Drawing.Size(40, 20);
            this.txtPlayerCard3.TabIndex = 11;
            // 
            // txtPlayerCard2
            // 
            this.txtPlayerCard2.Location = new System.Drawing.Point(65, 84);
            this.txtPlayerCard2.Name = "txtPlayerCard2";
            this.txtPlayerCard2.Size = new System.Drawing.Size(40, 20);
            this.txtPlayerCard2.TabIndex = 12;
            // 
            // txtDealerCard3
            // 
            this.txtDealerCard3.Location = new System.Drawing.Point(111, 146);
            this.txtDealerCard3.Name = "txtDealerCard3";
            this.txtDealerCard3.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard3.TabIndex = 13;
            // 
            // txtDealerCard2
            // 
            this.txtDealerCard2.Location = new System.Drawing.Point(65, 146);
            this.txtDealerCard2.Name = "txtDealerCard2";
            this.txtDealerCard2.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard2.TabIndex = 14;
            // 
            // txtDealerCard1
            // 
            this.txtDealerCard1.Location = new System.Drawing.Point(16, 146);
            this.txtDealerCard1.Name = "txtDealerCard1";
            this.txtDealerCard1.Size = new System.Drawing.Size(40, 20);
            this.txtDealerCard1.TabIndex = 15;
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Location = new System.Drawing.Point(13, 57);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(62, 13);
            this.lblPlayerCards.TabIndex = 16;
            this.lblPlayerCards.Text = "Your Cards:";
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Location = new System.Drawing.Point(13, 120);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(78, 13);
            this.lblDealerCards.TabIndex = 17;
            this.lblDealerCards.Text = "Dealer\'s Cards:";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 257);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.txtDealerCard1);
            this.Controls.Add(this.txtDealerCard2);
            this.Controls.Add(this.txtDealerCard3);
            this.Controls.Add(this.txtPlayerCard2);
            this.Controls.Add(this.txtPlayerCard3);
            this.Controls.Add(this.txtPlayerCard1);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.mnuOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmSimplified21";
            this.Text = "Simplified21";
            this.Load += new System.EventHandler(this.frmSimplified21_Load);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.TextBox txtPlayerCard1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtPlayerCard3;
        private System.Windows.Forms.TextBox txtPlayerCard2;
        private System.Windows.Forms.TextBox txtDealerCard3;
        private System.Windows.Forms.TextBox txtDealerCard2;
        private System.Windows.Forms.TextBox txtDealerCard1;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Label lblDealerCards;
    }
}

