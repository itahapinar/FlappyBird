

namespace FlappyBird
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbBackGround = new Panel();
            pipeTop3 = new PictureBox();
            pipeBottom3 = new PictureBox();
            pbBird = new PictureBox();
            pipeBottom2 = new PictureBox();
            pipeTop2 = new PictureBox();
            pipeTop1 = new PictureBox();
            pipeBottom1 = new PictureBox();
            pbGround = new Panel();
            gameTimer = new System.Windows.Forms.Timer(components);
            pbBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pipeTop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom1).BeginInit();
            SuspendLayout();
            // 
            // pbBackGround
            // 
            pbBackGround.BackgroundImage = Properties.Resources.background;
            pbBackGround.BackgroundImageLayout = ImageLayout.Stretch;
            pbBackGround.Controls.Add(pipeTop3);
            pbBackGround.Controls.Add(pipeBottom3);
            pbBackGround.Controls.Add(pbBird);
            pbBackGround.Controls.Add(pipeBottom2);
            pbBackGround.Controls.Add(pipeTop2);
            pbBackGround.Controls.Add(pipeTop1);
            pbBackGround.Controls.Add(pipeBottom1);
            pbBackGround.Dock = DockStyle.Fill;
            pbBackGround.Location = new Point(0, 0);
            pbBackGround.Name = "pbBackGround";
            pbBackGround.Size = new Size(858, 497);
            pbBackGround.TabIndex = 0;
            pbBackGround.Paint += panel1_Paint;
            // 
            // pipeTop3
            // 
            pipeTop3.BackColor = Color.Transparent;
            pipeTop3.BackgroundImage = (Image)resources.GetObject("pipeTop3.BackgroundImage");
            pipeTop3.BackgroundImageLayout = ImageLayout.Stretch;
            pipeTop3.Location = new Point(731, -3);
            pipeTop3.Name = "pipeTop3";
            pipeTop3.Size = new Size(101, 178);
            pipeTop3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeTop3.TabIndex = 10;
            pipeTop3.TabStop = false;
            // 
            // pipeBottom3
            // 
            pipeBottom3.BackColor = Color.Transparent;
            pipeBottom3.BackgroundImageLayout = ImageLayout.Stretch;
            pipeBottom3.Image = (Image)resources.GetObject("pipeBottom3.Image");
            pipeBottom3.Location = new Point(749, 260);
            pipeBottom3.Name = "pipeBottom3";
            pipeBottom3.Size = new Size(75, 203);
            pipeBottom3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeBottom3.TabIndex = 9;
            pipeBottom3.TabStop = false;
            // 
            // pbBird
            // 
            pbBird.BackColor = Color.Transparent;
            pbBird.BackgroundImageLayout = ImageLayout.Stretch;
            pbBird.Image = (Image)resources.GetObject("pbBird.Image");
            pbBird.Location = new Point(181, 194);
            pbBird.Name = "pbBird";
            pbBird.Size = new Size(79, 63);
            pbBird.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBird.TabIndex = 8;
            pbBird.TabStop = false;
            // 
            // pipeBottom2
            // 
            pipeBottom2.BackColor = Color.Transparent;
            pipeBottom2.BackgroundImage = (Image)resources.GetObject("pipeBottom2.BackgroundImage");
            pipeBottom2.BackgroundImageLayout = ImageLayout.Stretch;
            pipeBottom2.Location = new Point(541, 277);
            pipeBottom2.Name = "pipeBottom2";
            pipeBottom2.Size = new Size(110, 153);
            pipeBottom2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeBottom2.TabIndex = 6;
            pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            pipeTop2.BackColor = Color.Transparent;
            pipeTop2.BackgroundImage = (Image)resources.GetObject("pipeTop2.BackgroundImage");
            pipeTop2.BackgroundImageLayout = ImageLayout.Stretch;
            pipeTop2.Location = new Point(557, -22);
            pipeTop2.Name = "pipeTop2";
            pipeTop2.Size = new Size(94, 178);
            pipeTop2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeTop2.TabIndex = 5;
            pipeTop2.TabStop = false;
            // 
            // pipeTop1
            // 
            pipeTop1.BackColor = Color.Transparent;
            pipeTop1.BackgroundImage = (Image)resources.GetObject("pipeTop1.BackgroundImage");
            pipeTop1.BackgroundImageLayout = ImageLayout.Stretch;
            pipeTop1.Location = new Point(342, -37);
            pipeTop1.Name = "pipeTop1";
            pipeTop1.Size = new Size(74, 212);
            pipeTop1.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeTop1.TabIndex = 4;
            pipeTop1.TabStop = false;
            // 
            // pipeBottom1
            // 
            pipeBottom1.BackColor = Color.Transparent;
            pipeBottom1.BackgroundImage = (Image)resources.GetObject("pipeBottom1.BackgroundImage");
            pipeBottom1.BackgroundImageLayout = ImageLayout.Stretch;
            pipeBottom1.Location = new Point(342, 277);
            pipeBottom1.Name = "pipeBottom1";
            pipeBottom1.Size = new Size(88, 145);
            pipeBottom1.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeBottom1.TabIndex = 3;
            pipeBottom1.TabStop = false;
            // 
            // pbGround
            // 
            pbGround.BackgroundImage = Properties.Resources.ground;
            pbGround.BackgroundImageLayout = ImageLayout.Stretch;
            pbGround.Dock = DockStyle.Bottom;
            pbGround.Location = new Point(0, 402);
            pbGround.Name = "pbGround";
            pbGround.Size = new Size(858, 95);
            pbGround.TabIndex = 1;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(858, 497);
            Controls.Add(pbGround);
            Controls.Add(pbBackGround);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pbBackGround.ResumeLayout(false);
            pbBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pipeTop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom1).EndInit();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            string text = $"Score : {_score}";

            using var font = new Font("Courier New", 22, FontStyle.Bold);

            
            g.DrawString(text, font, Brushes.Black, 8, 8);
            g.DrawString(text, font, Brushes.Black, 12, 8);
            g.DrawString(text, font, Brushes.Black, 8, 12);
            g.DrawString(text, font, Brushes.Black, 12, 12);

            
            g.DrawString(text, font, Brushes.LightCyan, 10, 10);
        }

        #endregion

        private Panel pbBackGround;
        private Panel pbGround;
        private PictureBox pipeBottom1;
        private PictureBox pipeTop1;
        private PictureBox pipeTop2;
        private PictureBox pipeBottom2;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pbBird;
        private PictureBox pipeBottom3;
        private PictureBox pipeTop3;
    }
}
