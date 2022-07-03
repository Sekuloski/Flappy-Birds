using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private static int speed = 10;
        private float gravity = 0.00981f/1.5f;
        private int score = 0;
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
            random = new Random();
            SetPipeLocations();
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            stopWatch = new Stopwatch();
            stopWatch.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            scoreText.Text = score.ToString();
            TimeSpan ts = stopWatch.Elapsed;
            double FirstFrame = ts.TotalMilliseconds;
            deltaTime = FirstFrame - Secondframe;
            Counter += deltaTime;
            ApplyGravity();
            MovePipes();
            Secondframe = ts.TotalMilliseconds;
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
            if (e.KeyCode == Keys.Space)
            {
                velocity = -1.2;
                Console.WriteLine(velocity);
                bird.Top += (int)(velocity * deltaTime);
            }
        }
        private void JumpMouse(object sender, MouseEventArgs e)
        {
            velocity = -1.1;
            Console.WriteLine(velocity);
            bird.Top += (int)(velocity * deltaTime);
        }

        private void MovePipes()
        {
            pipeTop1.Left -= speed;
            pipeBottom1.Left -= speed;
            if(pipeBottom1.Left < -180)
            {
                pipeBottom1.Left = 1280;
                pipeTop1.Left = 1280;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom1.Top = (int)newHeight;
                pipeTop1.Top = (int)newHeight - 714;
                score++;
            }

            pipeTop2.Left -= speed;
            pipeBottom2.Left -= speed;
            if (pipeBottom2.Left < -180)
            {
                pipeBottom2.Left = 1280;
                pipeTop2.Left = 1280;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom2.Top = (int)newHeight;
                pipeTop2.Top = (int)newHeight - 714;
                score++;
            }

            pipeTop3.Left -= speed;
            pipeBottom3.Left -= speed;
            if (pipeBottom3.Left < -180)
            {
                pipeBottom3.Left = 1280;
                pipeTop3.Left = 1280;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom3.Top = (int)newHeight;
                pipeTop3.Top = (int)newHeight - 714;
                score++;
            }

            pipeTop4.Left -= speed;
            pipeBottom4.Left -= speed;
            if (pipeBottom4.Left < -180)
            {
                pipeBottom4.Left = 1280;
                pipeTop4.Left = 1280;
                newHeight = random.NextDouble() * 248 + 276;
                pipeBottom4.Top = (int)newHeight;
                pipeTop4.Top = (int)newHeight - 714;
                score++;
            }
        }

        private void SetPipeLocations()
        {
            newHeight = random.NextDouble() * 248 + 276;
            pipeBottom1.Top = (int)newHeight;
            pipeTop1.Top = (int)newHeight - 714;

            newHeight = random.NextDouble() * 248 + 276;
            pipeBottom2.Top = (int)newHeight;
            pipeTop2.Top = (int)newHeight - 714;

            newHeight = random.NextDouble() * 248 + 276;
            pipeBottom3.Top = (int)newHeight;
            pipeTop3.Top = (int)newHeight - 714;

            newHeight = random.NextDouble() * 248 + 276;
            pipeBottom4.Top = (int)newHeight;
            pipeTop4.Top = (int)newHeight - 714;
        }

    }
}
