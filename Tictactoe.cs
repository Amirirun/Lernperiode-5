using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamingconsole
{
    public partial class Tictactoe : Form
    {
        
        enum PlayerTurn { None, Player1, Player2 }
        enum Winner { None, Player1, Player2, Draw }

        PlayerTurn turn;
        Winner winner;
        System.Windows.Forms.Timer hideTimer = new System.Windows.Forms.Timer();
        





        void OnNewGame()

        {
            PictureBox[] allPictures = {pictureBox0,
                                         pictureBox1,
                                         pictureBox2,
                                         pictureBox3,
                                         pictureBox4,
                                         pictureBox5,
                                         pictureBox6,
                                         pictureBox7,
                                         pictureBox8,
                                       };
            //Clear all game board cells    
            foreach (var p in allPictures)
                p.Image = null;
            turn = PlayerTurn.Player1;
            winner = Winner.None;
          
            ShowTurn();
        }



        Winner GetWinner()
        {

            int[][] winPatterns = new int[][]
            {
                // Reihen
                new int[] {0, 1, 2},
                new int[] {3, 4, 5},
                new int[] {6, 7, 8},
                // Spalten
                new int[] {0, 3, 6},
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                // Diagonalen
                new int[] {0, 4, 8},
                new int[] {2, 4, 6}
            };


            PictureBox[] allPictures = {
        pictureBox0, pictureBox1, pictureBox2,
        pictureBox3, pictureBox4, pictureBox5,
        pictureBox6, pictureBox7, pictureBox8
    };

            // Gewinner prüfen
            foreach (var pattern in winPatterns)
            {
                PictureBox a = allPictures[pattern[0]];
                PictureBox b = allPictures[pattern[1]];
                PictureBox c = allPictures[pattern[2]];

                if (a.Image != null && a.Image == b.Image && a.Image == c.Image)
                {
                    if (a.Image == player1.Image)
                        return Winner.Player1;
                    else
                        return Winner.Player2;
                }
            }


            foreach (var p in allPictures)
            {
                if (p.Image == null)
                    return Winner.None;
            }




            return Winner.Draw;
        }

        void ShowTurn()
        {
            string status = "";

            switch (winner)
            {
                case Winner.None:
                    if (turn == PlayerTurn.Player1)
                        status = "Turn: Player 1";
                    else
                        status = "Turn: Player 2";
                    break;

                case Winner.Player1:
                                    status = "Player 1 Wins!";
              
                                    pictureBox10.Visible = true;
                                    hideTimer.Start();
                                    break;

                case Winner.Player2:
                                    status = "Player 2 Wins!";
                    
                                    pictureBox10.Visible = true;
                                    hideTimer.Start();
                                    break;

                case Winner.Draw:
                                    status = "Well, no one wins this time!";
                                    pictureBox10.Visible = true;
                                    hideTimer.Start();
                                    break;
            }

            lblStatus.Text = status;

        }
        private void HidePictureBox10(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            hideTimer.Stop();
        }
        public Tictactoe()
        {
            InitializeComponent();
            pictureBox10.Visible = false;
            hideTimer.Interval = 5300;
            hideTimer.Tick += HidePictureBox10;


        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Tictactoe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (p.Image != null || winner != Winner.None)
                return;

            if (turn == PlayerTurn.Player1)
                p.Image = player1.Image;
            else
                p.Image = player2.Image;

            
            winner = GetWinner();

            if (winner == Winner.None)
            {
                turn = (turn == PlayerTurn.Player1) ? PlayerTurn.Player2 : PlayerTurn.Player1;
            }
            else
            {
                turn = PlayerTurn.None; // Gave over
            }

            ShowTurn();
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to start a new game?",
                                         "New Game",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                OnNewGame();
        }

        
        

      

        private void Tictactoe_Load(object sender, EventArgs e)
        {
            OnNewGame();
        }

       
       


    }
}
