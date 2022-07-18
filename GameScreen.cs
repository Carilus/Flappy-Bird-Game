using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Game_Screen : Form
    {
        int pipeSpeed = 10;
        int gravity = 15;
        public int score = 1;
        public Game_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scores.Text = "Score:"+score.ToString();

            if(pipeBottom.Left <-10)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -10)
            {
                pipeTop.Left = 800;
                score++;
            }
            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds)||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds)||flappyBird.Top<-20)
            {
                endGame();
                this.Hide();
                StartMenu startMenu = new StartMenu();
                startMenu.Show();
            }
            if(score%5 == 0)
            {
                pipeSpeed +=3;
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;

            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            timer.Stop();
            lblGameOver.Text = "Game Over!!!";
            flappyBird.Visible = false;
            pipeBottom.Visible = false;
            pipeTop.Visible = false;
        }
    }
}
