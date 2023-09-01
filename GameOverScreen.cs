using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class GameOverScreen : Form
    {
        //Game over window construcor
        //score = winner's score
        //winner = Snake1 (if 1); Snake2 (if 2) ; Snake1 (if game was only for one player , winner = 0)
        //winner = tie (if 3)
        public GameOverScreen(int winner, int score)
        {
            this.StartPosition = FormStartPosition.CenterScreen;  //Sets to center of the screen
            InitializeComponent();
            if (winner == 1)
            {
                this.label1.Text = "Player 1 Won!  Your score: " + score;
            }
            else if (winner == 2)
            {
                this.label1.Text = "Player 2 Won!  Your score: " + score;
            }
            else if (winner == 3)
            {
                this.label1.Text = "Draw!    Score is: " + score;
            }
            //If only one player played the game
            else if (winner == 0)
            {
                this.label1.Text = "Your score: " + score;
            }

        }
        //Close the Game over window
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
