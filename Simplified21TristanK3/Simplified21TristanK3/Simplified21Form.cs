using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21TristanK3
{
    public partial class frmSimplified21 : Form
    {
        //Declare variables
        Random randomNumber = new Random();
        public int pCard1 = 0;
        public int pCard2 = 0;
        public int pCard3 = 0;
        public int dCard1 = 0;
        public int dCard2 = 0;
        public int dCard3 = 0;
        public int pTotal = 0;
        public int dTotal = 0;

        public string playerCard1;
        public string playerCard2;
        public string playerCard3;
        public string dealerCard1;
        public string dealerCard2;
        public string dealerCard3;



        public frmSimplified21()
        {
            InitializeComponent();

            //Hide the outcome label
            lblOutcome.Text = "";
        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {
            //Generate the players numbers
            pCard1 = randomNumber.Next(1, 10);
            pCard2 = randomNumber.Next(1, 10);
            dCard1 = randomNumber.Next(1, 10);
            dCard2 = randomNumber.Next(1, 10);
            dCard3 = randomNumber.Next(1, 10);

            //Convert card numbers into string to be displayed
            playerCard1 = Convert.ToString(pCard1);
            playerCard2 = Convert.ToString(pCard2);
            dealerCard1 = Convert.ToString(dCard1);
            dealerCard2 = Convert.ToString(dCard2);
            dealerCard3 = Convert.ToString(dCard3);

            //Display the players cards
            txtPlayerCard1.Text = playerCard1;
            txtPlayerCard2.Text = playerCard2;

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //Hide the buttons
            btnHit.Hide();
            btnStay.Hide();

            //Generate a third card for the player
            pCard3 = randomNumber.Next(1, 10);

            //Convert the card to a string
            playerCard3 = Convert.ToString(pCard3);

            //Display the players card
            txtPlayerCard3.Text = playerCard3;

            //Display the dealers cards
            txtDealerCard1.Text = dealerCard1;
            txtDealerCard2.Text = dealerCard2;
            txtDealerCard3.Text = dealerCard3;

            //Calculate the totals
            pTotal = pCard1 + pCard2 + pCard3;
            dTotal = dCard1 + dCard2 + dCard3;

            //Find the winner
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

        private void btnStay_Click(object sender, EventArgs e)
        {
            //Hide the buttons
            btnHit.Hide();
            btnStay.Hide();

            //Display the dealers cards
            txtDealerCard1.Text = dealerCard1;
            txtDealerCard2.Text = dealerCard2;
            txtDealerCard3.Text = dealerCard3;

            //Calculate the totals
            pTotal = pCard1 + pCard2;
            dTotal = dCard1 + dCard2 + dCard3;

            //Find the winner
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

        private void mniExit_Click(object sender, EventArgs e)
        {
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

            //Hide the outcome label
            lblOutcome.Text = "";

            //Show the buttons
            btnHit.Show();
            btnStay.Show();

            //Clear the textboxes
            txtPlayerCard1.Clear();
            txtPlayerCard2.Clear();
            txtPlayerCard3.Clear();
            txtDealerCard1.Clear();
            txtDealerCard2.Clear();
            txtDealerCard3.Clear();

            //Generate the players numbers
            pCard1 = randomNumber.Next(1, 10);
            pCard2 = randomNumber.Next(1, 10);
            dCard1 = randomNumber.Next(1, 10);
            dCard2 = randomNumber.Next(1, 10);
            dCard3 = randomNumber.Next(1, 10);

            //Convert card numbers into string to be displayed
            playerCard1 = Convert.ToString(pCard1);
            playerCard2 = Convert.ToString(pCard2);
            dealerCard1 = Convert.ToString(dCard1);
            dealerCard2 = Convert.ToString(dCard2);
            dealerCard3 = Convert.ToString(dCard3);

            //Display the players cards
            txtPlayerCard1.Text = playerCard1;
            txtPlayerCard2.Text = playerCard2;
        }
    }
}
