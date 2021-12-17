using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class game : Form
    {

        int pipespeed = 7;
        int gravity = 10;
        int score = 0; 

        public game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pillarBottom.Left -= pipespeed;
            pillarTop.Left -= pipespeed;
            Score.Text = "Score: " + score.ToString();

            if(pillarBottom.Left < -50)
            {
                pillarBottom.Left = 550;
                score++;
            }
            if (pillarTop.Left < -50)
            {
                pillarTop.Left = 600;
                score++;

            }

            if(bird.Bounds.IntersectsWith(pillarBottom.Bounds) || bird.Bounds.IntersectsWith(pillarTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds)){
                endGame();
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                Console.WriteLine(bird.Location.Y);

                if (bird.Location.Y < 20)
                {
                    bird.Location = new Point(bird.Location.X, 0);

                    gravity = 0;
                    
                }
               
                else
                {
                    gravity = -10;
                }
            }

        }

        private void endGame()
        {
            timer.Stop();
            Score.Text += " Game Over";
        }
    }
}
