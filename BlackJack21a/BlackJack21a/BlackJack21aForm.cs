/*
 * Created By: Tristan Kalabric
 * Created On: Nov 12, 2018
 * Created For: ICS3U Programming
 * Major Assignment #6b - Simplified 21
 * This program displays a working game of blackjack
 */
using BlackJack21a;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21a
{
    public partial class BlackJack21aForm : Form
    {
        public Deck currentdeck { get; set; }
        public Hand player_hand { get; set; }
        public Hand dealer_hand { get; set; }
        public int numcards { get; set; }
        public BlackJack21aForm()
        {
            InitializeComponent();
            btnDeal.Visible = true; // Deal button is visible
            btnHit.Visible = false; // Hit button hidden
            btnStay.Visible = false; // Stay button hidden
            picUCard1.Visible = true; //showing spot for first 2 cards
            picUCard2.Visible = true;
            picUCard3.Visible = false; //hiding the rest (depends if players wnats more cards by clicking Hit button)
            picUCard4.Visible = false;
            picUCard5.Visible = false;
            picUCard6.Visible = false;
            picCCard1.Visible = false;
            picCCard2.Visible = false;
            picCCard3.Visible = false;
            picCCard4.Visible = false;
            picCCard5.Visible = false;
            picCCard6.Visible = false;
            txtScore.Text = "Welcome to Tristan's BlackJack..." + Environment.NewLine;
            txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
        } //END Form1

        private void button3_Click_1(object sender, EventArgs e)
        {
            end_game(player_hand, dealer_hand);
        }

        // *** Display current hand ***
        public void display_hand(Hand playerhand)
        {
            //Set the counter to 0
            int count = 0;
            string currentcard_picture = "";
            //Builds the file names of the cards in the players hand to display it
            if (playerhand.cards != null && playerhand != null)
                foreach (Card currentcard in playerhand.cards)
                {
                    if (currentcard != null && currentcard.suit != "")
                    {
                        if (currentcard.value < 10)
                            currentcard_picture = "_0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 10)
                            currentcard_picture = "_" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 11)
                            currentcard_picture = "J" + "_" + currentcard.suit;
                        if (currentcard.value == 12)
                            currentcard_picture = "Q" + "_" + currentcard.suit;
                        if (currentcard.value >= 13)
                            currentcard_picture = "K" + "_" + currentcard.suit;
                    }
                    else
                        currentcard_picture = "space";
                    if (count == 0)
                    {
                        picUCard1.Visible = true; //Showing the first card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard1.Image = myImage;
                        picUCard1.BringToFront();
                        picUCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 1)
                    {
                        picUCard2.Visible = true; //Showing the second card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard2.Image = myImage;
                        picUCard2.BringToFront();
                        picUCard2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 2)
                    {
                        picUCard3.Visible = true; //Showing the third card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard3.Image = myImage;
                        picUCard3.BringToFront();
                        picUCard3.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 3)
                    {
                        picUCard4.Visible = true; //Showing the fourth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard4.Image = myImage;
                        picUCard4.BringToFront();
                        picUCard4.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 4)
                    {
                        picUCard5.Visible = true; //Showing the fifth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard5.Image = myImage;
                        picUCard5.BringToFront();
                        picUCard5.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 5)
                    {
                        picUCard6.Visible = true; //Showing the sixth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picUCard6.Image = myImage;
                        picUCard6.BringToFront();
                        picUCard6.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 6)
                    {
                        picCCard1.Visible = true; //Showing the seventh card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard1.Image = myImage;
                        picCCard1.BringToFront();
                        picCCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 7)
                    {
                        picCCard2.Visible = true; //Showing the height card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard2.Image = myImage;
                        picCCard2.BringToFront();
                        picCCard2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 8)
                    {
                        picCCard3.Visible = true; //Showing the nineth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard3.Image = myImage;
                        picCCard3.BringToFront();
                        picCCard3.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 9)
                    {
                        picCCard4.Visible = true; //Showing the tenth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard4.Image = myImage;
                        picCCard4.BringToFront();
                        picCCard4.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 10)
                    {
                        picCCard5.Visible = true; //Showing the eleventh card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard5.Image = myImage;
                        picCCard5.BringToFront();
                        picCCard5.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 11)
                    {
                        picCCard6.Visible = true; //Showing the twelveth card
                        System.Resources.ResourceManager rm = global::BlackJack21a.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentcard_picture);
                        picCCard6.Image = myImage;
                        picCCard6.BringToFront();
                        picCCard6.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    count++;
                }
        } // end display hand

        private void end_game(Hand player_hand, Hand dealer_hand)
        {
            dealer_hand.deal_cards(currentdeck, numcards); //deal cards to dealer
            dealer_hand.evaluate_hand();
            while (dealer_hand.score < 15) //dealer stops getting cards if he has 15 or higher
            {
                dealer_hand.add_card(currentdeck, 1);
                dealer_hand.evaluate_hand();
            }

            bool winnerFound = false;

            if (player_hand.score > 21)
            {
                btnDeal.Visible = true; // Deal button is visible
                btnHit.Visible = false; // Hit button hidden
                btnStay.Visible = false; // Stay button hidden
                txtScore.Text = "You have " + player_hand.score + "." + Environment.NewLine;
                txtScore.Text += "Dealer has " + dealer_hand.score + "." + Environment.NewLine;
                txtScore.Text += "You bust - Better luck next time." + Environment.NewLine;
                txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
                winnerFound = true;
            }

            if ((dealer_hand.score > 21) && (!winnerFound))
            {
                txtScore.Text = player_hand.result + Environment.NewLine;
                txtScore.Text += "Dealer has " + dealer_hand.score + "." + Environment.NewLine;
                txtScore.Text += "Congratulations you win!" + Environment.NewLine;
                txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
                winnerFound = true;
            }

            if ((player_hand.score == 21) && (dealer_hand.score == 21))
            {
                txtScore.Text = player_hand.result + Environment.NewLine;
                txtScore.Text += "Dealer has " + dealer_hand.score + "." + Environment.NewLine;
                txtScore.Text += "Player and Dealer have Black Jack - Dealer wins." + Environment.NewLine;
                txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
                winnerFound = true;
            }

            if ((player_hand.score > dealer_hand.score) && (!winnerFound))
            {
                txtScore.Text = player_hand.result + Environment.NewLine;
                txtScore.Text += "Dealer has " + dealer_hand.score + "." + Environment.NewLine;
                txtScore.Text += "Congratulations you win!" + Environment.NewLine;
                txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
                winnerFound = true;
            }
            if ((player_hand.score < dealer_hand.score) && (!winnerFound))
            {
                txtScore.Text = player_hand.result + Environment.NewLine;
                txtScore.Text += "Dealer has " + dealer_hand.score + "." + Environment.NewLine;
                txtScore.Text += "Dealer wins." + Environment.NewLine;
                txtScore.Text += "PresPress Deal to begin a new game." + Environment.NewLine;
                winnerFound = true;
            }

            btnDeal.Visible = true; // deal button is visible
            btnHit.Visible = false; // hit button hidden
            btnStay.Visible = false; // stick button hidden

        } // End end game

        private void button1_Click(object sender, EventArgs e)
        {
            {
                numcards = 2; //deal 2 cards initially
                currentdeck = new Deck(); //create new deck of cards
                player_hand = new Hand(numcards); //create hand for player
                dealer_hand = new Hand(numcards); // create hand for dealer
                btnDeal.Visible = true; // Deal button is visible
                btnHit.Visible = false; // Hit button hidden
                btnStay.Visible = false; // Stay button hidden
                picUCard1.Visible = true; //showing spot for first 2 cards
                picUCard2.Visible = true;
                picUCard3.Visible = false; //hiding the rest
                picUCard4.Visible = false;
                picUCard5.Visible = false;
                picUCard6.Visible = false;
                picCCard1.Visible = false;
                picCCard2.Visible = false;
                picCCard3.Visible = false;
                picCCard4.Visible = false;
                picCCard5.Visible = false;
                picCCard6.Visible = false;
                txtScore.Text = "Welcome to Tristan's BlackJack..." + Environment.NewLine;
                txtScore.Text += "Press Deal to begin a new game." + Environment.NewLine;
                player_hand.deal_cards(currentdeck, numcards);
                display_hand(player_hand);
                player_hand.evaluate_hand();
                if (player_hand.score >= 21)
                {
                    end_game(player_hand, dealer_hand);
                }
                else
                {
                    txtScore.Text = player_hand.result + Environment.NewLine;
                }
                btnDeal.Visible = false;
                btnHit.Visible = true;
                btnStay.Visible = true;
            }

        } //End partial Class

        private void button2_Click(object sender, EventArgs e)
        {
            player_hand.add_card(currentdeck, 1);
            display_hand(player_hand);
            player_hand.evaluate_hand();
            txtScore.Text = player_hand.result + Environment.NewLine;
            btnDeal.Visible = false;
            btnHit.Visible = true;
            btnStay.Visible = true;
            if (player_hand.score >= 21)
            {
                end_game(player_hand, dealer_hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            end_game(player_hand, dealer_hand);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }
    }
}
