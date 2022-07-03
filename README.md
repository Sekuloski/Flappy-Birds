# Flappy Bird 

This project is a recreation of the famous "Flappy Bird" game that took the mobile gaming market by storm. The game is an infinite loop of jumping in the middle of two obstacles. Eventually the game speeds and becomes hard, while giving the player more and more points. As many people pointed out at the release of the original game, it was a horrible experience and very difficult. That is not changed here.

## How to play

The game is very simple. **Jump** in the middle of the obstacles. Jumping is done using the left mouse button or the up arrow. The game ends if the player either hits the obstacles, hits the ground, or goes too high. The goal is to get as far as possible, i.e get the most points. The highest score is kept on a local file.

![image](https://user-images.githubusercontent.com/79922210/177042737-fbf5f1da-128a-494d-bc01-483cd3065468.png)

## The code

All the code is in one file, because all the variables required need to talk to each other easily. The game works by moving 4 pairs of pillars (obstacles) to the right and moving them back as soon as they leave the screen. This also happens to the ground, divided into 2 pieces. The player (the bird) is only controlled in the Y axis by a simple gravity simulation and a jump function, which adds velocity to the player.

```c#
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
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(Timer_Tick);
            stopWatch = new Stopwatch();
        }
        private void StartGame(){...}        
        private void RestartGame(){...}  
        private void GetHighScore(){...}  
        private void SetHighScore(){...}  
        private void UpdateScore(){...}  
        private void Timer_Tick(object sender, EventArgs e){...}  
        private void CheckCollisions(){...}  
        private void EndGame(){...}  
        private void ApplyGravity(){...}  
        private void Jump(object sender, KeyEventArgs e){...}  
        private void JumpMouse(object sender, MouseEventArgs e){...}  
        private void MovePipes(){...}  
        private void MoveGrass(){...}  
        private void SetPipeLocations(){...}  
        private void start_MouseClick(object sender, MouseEventArgs e){...}  
        private void restart_MouseClick(object sender, MouseEventArgs e){...}  
    }
```
