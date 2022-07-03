using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool playing = false;
        private static int speed;
        private float gravity;
        private int score = 0;
        private int highScore;
        private double velocity = 0;
        private double deltaTime = 0;
        private static double Counter = 0;
        private static double Secondframe = 0;
        private Stopwatch stopWatch;
        private Random random;
        private double newHeight = 0;

        public Form1()
        {
            InitializeComponent();
            GetHighScore();
            random = new Random();
            SetPipeLocations();
            SetCloudLocations();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(Timer_Tick);
            stopWatch = new Stopwatch();
        }
        private void StartGame()
        {
            speed = 5;
            gravity = 0.00981f / 1.5f;
            bird.Left = 133;
            bird.Top = 92;
            playing = true;
            timer.Start();
            stopWatch.Start();
        }        
        private void RestartGame()
        {
            score = 0;
            scoreText.Text = "0";
            speed = 5;
            gravity = 0.00981f / 1.5f;
            bird.Left = 133;
            bird.Top = 92;
            playing = true;
            SetPipeLocations();
            timer.Start();
            stopWatch.Start();
        }
        private void GetHighScore()
        {
            if (!File.Exists("highscore.txt"))
            {
                TextWriter textWriter = new StreamWriter("highscore.txt");
                textWriter.WriteLine(0);
                textWriter.Close();
                highScore = 0;
                return;
            }

            TextReader textReader = new StreamReader("highscore.txt");
            highScore = int.Parse(textReader.ReadLine());
            Console.WriteLine(highScore);
            highscore.Text = highScore.ToString();
        }
        private void SetHighScore()
        {
            File.Delete("highscore.txt");
            TextWriter textWriter = new StreamWriter("highscore.txt");
            textWriter.WriteLine(score);
            textWriter.Close();
            highscore.Text = score.ToString();
        }
        private void UpdateScore()
        {
            score++;
            if (score % 10 == 0)
            {
                speed += 1;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckCollisions();
            scoreText.Text = score.ToString();
            TimeSpan ts = stopWatch.Elapsed;
            double FirstFrame = ts.TotalMilliseconds;
            deltaTime = FirstFrame - Secondframe;
            Counter += deltaTime;
            ApplyGravity();
            MovePipes();
            MoveGrass();
            MoveClouds();
            Secondframe = ts.TotalMilliseconds;
        }
        private void CheckCollisions()
        {
            Console.WriteLine(bird.Top);
            Console.WriteLine(this.Size.Height);
            if (bird.Bounds.IntersectsWith(pipeBottom1.Bounds)  ||
                bird.Bounds.IntersectsWith(pipeTop1.Bounds)     ||
                bird.Bounds.IntersectsWith(pipeBottom2.Bounds)  ||
                bird.Bounds.IntersectsWith(pipeTop2.Bounds)     ||
                bird.Bounds.IntersectsWith(pipeBottom3.Bounds)  ||
                bird.Bounds.IntersectsWith(pipeTop3.Bounds)     ||
                bird.Bounds.IntersectsWith(pipeBottom4.Bounds)  ||
                bird.Bounds.IntersectsWith(pipeTop4.Bounds)     ||
                bird.Bounds.IntersectsWith(grass.Bounds)        ||
                bird.Top < 0)
            {
                Console.WriteLine("Collision");
                EndGame();
            }
        }
        private void EndGame()
        {
            stopWatch.Stop();
            timer.Stop();
            playing = false;
            speed = 0;
            gravity = 0;
            restart.Visible = true;
            restart.Enabled = true;
            if (score > highScore)
            {
                SetHighScore();
            }
        }
        private void ApplyGravity()
        {
            velocity += gravity * deltaTime;
            if (velocity > 0.6)
            {
                velocity = 0.6;
            }
            bird.Top += (int)(velocity * deltaTime);
        }
        private void Jump(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && playing)
            {
                velocity = -1.1;
                bird.Top += (int)(velocity * deltaTime);
                
            }
        }
        private void JumpMouse(object sender, MouseEventArgs e)
        {
            if (playing)
            {
                velocity = -1.1;
                bird.Top += (int)(velocity * deltaTime);
            }
        }
        private void MovePipes()
        {
            pipeTop1.Left -= speed;
            pipeBottom1.Left -= speed;
            if(pipeBottom1.Left < -180)
            {
                pipeBottom1.Left = 1800;
                pipeTop1.Left = 1800;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom1.Top = (int)newHeight;
                pipeTop1.Top = (int)newHeight - 714;
                UpdateScore();
            }

            pipeTop2.Left -= speed;
            pipeBottom2.Left -= speed;
            if (pipeBottom2.Left < -180)
            {
                pipeBottom2.Left = 1800;
                pipeTop2.Left = 1800;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom2.Top = (int)newHeight;
                pipeTop2.Top = (int)newHeight - 714;
                UpdateScore();
            }

            pipeTop3.Left -= speed;
            pipeBottom3.Left -= speed;
            if (pipeBottom3.Left < -180)
            {
                pipeBottom3.Left = 1800;
                pipeTop3.Left = 1800;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom3.Top = (int)newHeight;
                pipeTop3.Top = (int)newHeight - 714;
                UpdateScore();
            }

            pipeTop4.Left -= speed;
            pipeBottom4.Left -= speed;
            if (pipeBottom4.Left < -180)
            {
                pipeBottom4.Left = 1800;
                pipeTop4.Left = 1800;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom4.Top = (int)newHeight;
                pipeTop4.Top = (int)newHeight - 714;
                UpdateScore();
            }
        }
        private void MoveGrass()
        {
            grass.Left -= speed;
            grass2.Left -= speed;
            if (grass.Left < -1444)
            {
                grass.Left = 1445;
                grass.BringToFront();
            }
            if (grass2.Left < -1444)
            {
                grass2.Left = 1445;
                grass2.BringToFront();
            }
        }
        private void MoveClouds()
        {
            clouds1.Left -= speed/2;
            clouds2.Left -= speed/2;
            if (clouds1.Left < -600)
            {
                clouds1.Left = 1400;
                clouds1.Top = (int)(random.NextDouble() * 470);
            }
            if (clouds2.Left < -600)
            {
                clouds2.Left = 1400;
                clouds2.Top = (int)(random.NextDouble() * 470);
            }
        }
        private void SetPipeLocations()
        {
            pipeBottom1.Visible = true;
            pipeBottom2.Visible = true;
            pipeBottom3.Visible = true;
            pipeBottom4.Visible = true;

            pipeTop1.Visible = true;
            pipeTop2.Visible = true;
            pipeTop3.Visible = true;
            pipeTop4.Visible = true;

            newHeight = random.NextDouble() * 248 + 300;
            pipeBottom1.Top = (int)newHeight;
            pipeBottom1.Left = 681;
            pipeTop1.Top = (int)newHeight - 800;
            pipeTop1.Left = 681;

            newHeight = random.NextDouble() * 248 + 300;
            pipeBottom2.Top = (int)newHeight;
            pipeBottom2.Left = 1188;
            pipeTop2.Top = (int)newHeight - 800;
            pipeTop2.Left = 1188;

            newHeight = random.NextDouble() * 248 + 300;
            pipeBottom3.Top = (int)newHeight;
            pipeBottom3.Left = 1675;
            pipeTop3.Top = (int)newHeight - 800;
            pipeTop3.Left = 1675;

            newHeight = random.NextDouble() * 248 + 300;
            pipeBottom4.Top = (int)newHeight;
            pipeBottom4.Left = 2152;
            pipeTop4.Top = (int)newHeight - 800;
            pipeTop4.Left = 2152;
        }
        private void SetCloudLocations()
        {
            clouds1.Visible = true;
            clouds2.Visible = true;

            clouds1.Top = (int)(random.NextDouble() * 470);
            clouds1.Left = 1400;
            clouds2.Top = (int)(random.NextDouble() * 470);
            clouds2.Left = 2000;
        }
        private void start_MouseClick(object sender, MouseEventArgs e)
        {
            StartGame();
            start.Enabled = false;
            start.Visible = false;
        }
        private void restart_MouseClick(object sender, MouseEventArgs e)
        {
            RestartGame();
            restart.Enabled = false;
            restart.Visible = false;
        }

    }
}
