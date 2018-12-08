using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21TristanK2
{
    public partial class frmSimplified21 : Form
    {
        //Declare variables
        public int pCard1 = 0;
        public int pCard2 = 0;
        public int pCard3 = 0;
        public int dCard1 = 0;
        public int dCard2 = 0;
        public int dCard3 = 0;
        public int pTotal = 0;
        public int dTotal = 0;
        public Random randomNumber = new Random();

        //Declare variables
        public string playCard1;
        public string playCard2;
        public string playCard3;
        public string dealCard1;
        public string dealCard2;
        public string dealCard3;

        public frmSimplified21()
        {
            InitializeComponent();

            //Hide label
            lblOutcome.Text = "";
        }

        private void lblPLayerCard2_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerCard3_Click(object sender, EventArgs e)
        {

        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //Calculate the players total
            pTotal = pCard1 + pCard2;

            //Calculate the dealers total
            dTotal = dCard1 + dCard2 + dCard3;

            //Display dealers cards
            this.txtDealerCard1.Text = dealCard1;
            this.txtDealerCard2.Text = dealCard2;
            this.txtDealerCard3.Text = dealCard3;

            //Calculate the winner
            if (pTotal > 21)
            {
                if (dTotal > 21)
                {
                    lblOutcome.Text = "Bust, Dealer Wins";
                }
                else
                {
                    lblOutcome.Text = "Dealer Wins";
                }
            }
            else
            {
                if (dTotal > 21)
                {
                    lblOutcome.Text = "You Win";
                }
                else
                {
                    if (pTotal > dTotal)
                    {
                        lblOutcome.Text = "You Win";
                    }
                    if (pTotal == dTotal)
                    {
                        lblOutcome.Text = "Tie";
                    }
                    if (pTotal < dTotal)
                    {
                        lblOutcome.Text = "Dealer Wins";
                    }
                }
            }
        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {
            //Set variables
            pCard1 = randomNumber.Next(1, 10);
            pCard2 = randomNumber.Next(1, 10);
            dCard1 = randomNumber.Next(1, 10);
            dCard2 = randomNumber.Next(1, 10);
            dCard3 = randomNumber.Next(1, 10);

            //Convert card numbers to a string to be displayed
            playCard1 = Convert.ToString(pCard1);
            playCard2 = Convert.ToString(pCard2);
            dealCard1 = Convert.ToString(dCard1);
            dealCard2 = Convert.ToString(dCard2);
            dealCard3 = Convert.ToString(dCard3);

            //Display the players cards
            this.txtPlayerCard1.Text = playCard1;
            this.txtPlayerCard2.Text = playCard2;

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //Generate another card for the player
            pCard3 = randomNumber.Next(1, 10);

            //Calculate player total
            pTotal = pCard1 + pCard2 + pCard3;

            //Calculate the dealers total
            dTotal = dCard1 + dCard2 + dCard3;

            //Convert to string
            playCard3 = Convert.ToString(pCard3);

            //Display new number
            this.txtPlayerCard3.Text = playCard3;
            this.txtDealerCard1.Text = dealCard1;
            this.txtDealerCard2.Text = dealCard2;
            this.txtDealerCard3.Text = dealCard3;

            //Calculate the winner
            if (pTotal > 21)
            {
                if (dTotal > 21)
                {
                    lblOutcome.Text = "Bust, Dealer Wins";
                }
                else
                {
                    lblOutcome.Text = "Dealer Wins";
                }
            }
            else
            {
                if (dTotal > 21)
                {
                    lblOutcome.Text = "You Win";
                }
                else
                {
                    if (pTotal > dTotal)
                    {
                        lblOutcome.Text = "You Win";
                    }
                    if (pTotal == dTotal)
                    {
                        lblOutcome.Text = "Tie";
                    }
                    if (pTotal < dTotal)
                    {
                        lblOutcome.Text = "Dealer Wins";
                    }
                }
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            //Set variables to 0
            pCard1 = 0;
            pCard2 = 0;
            pCard3 = 0;
            dCard1 = 0;
            dCard2 = 0;
            dCard3 = 0;
            pTotal = 0;
            dTotal = 0;

            //Hide label
            lblOutcome.Text = "";

            //Set variables
            pCard1 = randomNumber.Next(1, 10);
            pCard2 = randomNumber.Next(1, 10);
            dCard1 = randomNumber.Next(1, 10);
            dCard2 = randomNumber.Next(1, 10);
            dCard3 = randomNumber.Next(1, 10);

            //Convert card numbers to a string to be displayed
            playCard1 = Convert.ToString(pCard1);
            playCard2 = Convert.ToString(pCard2);
            dealCard1 = Convert.ToString(dCard1);
            dealCard2 = Convert.ToString(dCard2);
            dealCard3 = Convert.ToString(dCard3);

            //Display the players cards
            this.txtPlayerCard1.Text = playCard1;
            this.txtPlayerCard2.Text = playCard2;

            //Clear textboxes
            this.txtPlayerCard3.Clear();
            this.txtDealerCard1.Clear();
            this.txtDealerCard2.Clear();
            this.txtDealerCard3.Clear();
        }
    }
}
