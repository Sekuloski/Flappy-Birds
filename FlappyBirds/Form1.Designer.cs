namespace FlappyBirds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pipeTop4 = new System.Windows.Forms.PictureBox();
            this.pipeBottom4 = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom4)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 31);
            this.label.TabIndex = 4;
            this.label.Text = "Score:";
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBirds.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(38, 208);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(100, 75);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop1.Location = new System.Drawing.Point(511, -357);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(100, 500);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 1;
            this.pipeTop1.TabStop = false;
            // 
            // grass
            // 
            this.grass.Image = global::FlappyBirds.Properties.Resources.ground;
            this.grass.Location = new System.Drawing.Point(-11, 586);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(1296, 107);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass.TabIndex = 3;
            this.grass.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom1.Location = new System.Drawing.Point(511, 357);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(100, 500);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 0;
            this.pipeBottom1.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop2.Location = new System.Drawing.Point(891, -357);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(100, 500);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 6;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom2.Location = new System.Drawing.Point(891, 357);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(100, 500);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop3.Location = new System.Drawing.Point(1256, -357);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(100, 500);
            this.pipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop3.TabIndex = 8;
            this.pipeTop3.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom3.Location = new System.Drawing.Point(1256, 354);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(100, 500);
            this.pipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom3.TabIndex = 7;
            this.pipeBottom3.TabStop = false;
            // 
            // pipeTop4
            // 
            this.pipeTop4.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop4.Location = new System.Drawing.Point(1614, -316);
            this.pipeTop4.Name = "pipeTop4";
            this.pipeTop4.Size = new System.Drawing.Size(100, 500);
            this.pipeTop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop4.TabIndex = 10;
            this.pipeTop4.TabStop = false;
            // 
            // pipeBottom4
            // 
            this.pipeBottom4.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom4.Location = new System.Drawing.Point(1614, 354);
            this.pipeBottom4.Name = "pipeBottom4";
            this.pipeBottom4.Size = new System.Drawing.Size(100, 500);
            this.pipeBottom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom4.TabIndex = 9;
            this.pipeBottom4.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(100, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(29, 31);
            this.scoreText.TabIndex = 11;
            this.scoreText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeTop4);
            this.Controls.Add(this.pipeBottom4);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Flappy Birds";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jump);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JumpMouse);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.PictureBox pipeTop4;
        private System.Windows.Forms.PictureBox pipeBottom4;
        private System.Windows.Forms.Label scoreText;
    }
}

