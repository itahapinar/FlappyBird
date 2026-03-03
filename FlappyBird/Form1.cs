using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        private const int Gravity = 1;
        private const int JumpStrength = -10;

        private int _velocityY;
        private int _pipeSpeed = 5;
        private int _score;

        private readonly Random _rnd = new Random();

        
        private List<(PictureBox top, PictureBox bottom, bool scored)> _pipes;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Flappy Bird";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            DoubleBuffered = true;
            KeyPreview = true;

            _pipes = new List<(PictureBox, PictureBox, bool)>
            {
                (pipeTop1, pipeBottom1, false),
                (pipeTop2, pipeBottom2, false),
                (pipeTop3, pipeBottom3, false),
            };

            gameTimer.Interval = 20;
            gameTimer.Tick += GameTick;

            KeyDown += Form1_KeyDown;

            ResetGame();
            gameTimer.Start();
        }

        private static Rectangle Shrink(Rectangle r, int left, int top, int right, int bottom)
            => Rectangle.FromLTRB(r.Left + left, r.Top + top, r.Right - right, r.Bottom - bottom);

        private void ResetGame()
        {
            _score = 0;

            _velocityY = 0;

            pbBird.Left = 120;
            pbBird.Top = 200;

            int startX = ClientSize.Width + 50;  
            int spacing = 300;  

            for (int i = 0; i < _pipes.Count; i++)
            {
                int x = startX + i * spacing;
                SetPipeGap(_pipes[i].top, _pipes[i].bottom, x);
                _pipes[i] = (_pipes[i].top, _pipes[i].bottom, false);
            }
           

        }

        private void GameTick(object sender, EventArgs e)
        {
            
           
            _velocityY += Gravity;
            pbBird.Top += _velocityY;
            if (pbBird.Top < 0) pbBird.Top = 0;

            
            Rectangle birdHit = Shrink(pbBird.Bounds, 6, 6, 6, 6);

            
            if (birdHit.IntersectsWith(pbGround.Bounds))
            {
                GameOver();
                return;
            }

            for (int i = 0; i < _pipes.Count; i++)
            {
                var (top, bottom, scored) = _pipes[i];

                top.Left -= _pipeSpeed;
                bottom.Left -= _pipeSpeed;

                
                Rectangle topHit = Shrink(top.Bounds, 18, 4, 18, 4);
                Rectangle bottomHit = Shrink(bottom.Bounds, 18, 4, 18, 4);

                if (birdHit.IntersectsWith(topHit) || birdHit.IntersectsWith(bottomHit))
                {
                    GameOver();
                    return;
                }

                
                if (!scored && top.Right < pbBird.Left)
                {
                    scored = true;
                    _score++;
                    

                }

                
                if (top.Right < 0)
                {
                    int newX = GetRightMostPipeX() + 300; 
                    SetPipeGap(top, bottom, newX);
                    scored = false;
                }

                _pipes[i] = (top, bottom, scored);
                pbBackGround.Invalidate();
            }
        }

        private int GetRightMostPipeX()
            => _pipes.Max(p => p.top.Left);

        private void SetPipeGap(PictureBox top, PictureBox bottom, int x)
        {
            int gapSize = 150;
            int minTopHeight = 50;
            int maxTopHeight = 220;

            int topHeight = _rnd.Next(minTopHeight, maxTopHeight);

            top.Height = topHeight;
            top.Left = x;
            top.Top = 0;

            bottom.Left = x;
            bottom.Top = top.Bottom + gapSize;

            int groundTop = pbGround.Top;
            bottom.Height = groundTop - bottom.Top;
            if (bottom.Height < 10) bottom.Height = 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                _velocityY = JumpStrength;

            if (e.KeyCode == Keys.R)
            {
                ResetGame();
                gameTimer.Start();
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show($"GAME OVER! \nSCORE: {_score}\nPress R to Restart.");
        }

       

        


    }
}