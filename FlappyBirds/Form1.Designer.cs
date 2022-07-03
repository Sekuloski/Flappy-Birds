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
            this.start = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
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
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 11);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 39);
            this.label.TabIndex = 4;
            this.label.Text = "Score:";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyBirds.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(51, 256);
            this.bird.Margin = new System.Windows.Forms.Padding(4);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(133, 92);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop1.Location = new System.Drawing.Point(681, -439);
            this.pipeTop1.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(133, 615);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 1;
            this.pipeTop1.TabStop = false;
            // 
            // grass
            // 
            this.grass.Image = global::FlappyBirds.Properties.Resources.ground;
            this.grass.Location = new System.Drawing.Point(-21, 880);
            this.grass.Margin = new System.Windows.Forms.Padding(4);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(1931, 330);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass.TabIndex = 3;
            this.grass.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom1.Location = new System.Drawing.Point(681, 439);
            this.pipeBottom1.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(133, 615);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 0;
            this.pipeBottom1.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop2.Location = new System.Drawing.Point(1188, -439);
            this.pipeTop2.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(133, 615);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 6;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom2.Location = new System.Drawing.Point(1188, 439);
            this.pipeBottom2.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(133, 615);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop3.Location = new System.Drawing.Point(1675, -439);
            this.pipeTop3.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(133, 615);
            this.pipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop3.TabIndex = 8;
            this.pipeTop3.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom3.Location = new System.Drawing.Point(1675, 436);
            this.pipeBottom3.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(133, 615);
            this.pipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom3.TabIndex = 7;
            this.pipeBottom3.TabStop = false;
            // 
            // pipeTop4
            // 
            this.pipeTop4.Image = global::FlappyBirds.Properties.Resources.pipeTop;
            this.pipeTop4.Location = new System.Drawing.Point(2152, -389);
            this.pipeTop4.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop4.Name = "pipeTop4";
            this.pipeTop4.Size = new System.Drawing.Size(133, 615);
            this.pipeTop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop4.TabIndex = 10;
            this.pipeTop4.TabStop = false;
            // 
            // pipeBottom4
            // 
            this.pipeBottom4.Image = global::FlappyBirds.Properties.Resources.pipeBottom;
            this.pipeBottom4.Location = new System.Drawing.Point(2152, 436);
            this.pipeBottom4.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom4.Name = "pipeBottom4";
            this.pipeBottom4.Size = new System.Drawing.Size(133, 615);
            this.pipeBottom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom4.TabIndex = 9;
            this.pipeBottom4.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(133, 11);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(36, 39);
            this.scoreText.TabIndex = 11;
            this.scoreText.Text = "0";
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(960, 540);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(177, 80);
            this.start.TabIndex = 12;
            this.start.Text = "Play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // restart
            // 
            this.restart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(936, 540);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(230, 80);
            this.restart.TabIndex = 13;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeTop4);
            this.Controls.Add(this.pipeBottom4);
            this.Controls.Add(this.bird);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button restart;
    }
}

