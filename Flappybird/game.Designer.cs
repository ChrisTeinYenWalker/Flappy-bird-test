
namespace Flappybird
{
    partial class game
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
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pillarBottom = new System.Windows.Forms.PictureBox();
            this.pillarTop = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillarBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillarTop)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(46, 24);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(159, 46);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // bird
            // 
            this.bird.AccessibleName = "player";
            this.bird.Image = global::Flappybird.Properties.Resources.bird_1_;
            this.bird.Location = new System.Drawing.Point(65, 199);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(80, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.AccessibleName = "ground";
            this.ground.Image = global::Flappybird.Properties.Resources.ground_1_;
            this.ground.Location = new System.Drawing.Point(-6, 539);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1032, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pillarBottom
            // 
            this.pillarBottom.AccessibleName = "bottom pillar";
            this.pillarBottom.Image = global::Flappybird.Properties.Resources.pipe_1_;
            this.pillarBottom.Location = new System.Drawing.Point(275, 358);
            this.pillarBottom.Name = "pillarBottom";
            this.pillarBottom.Size = new System.Drawing.Size(123, 184);
            this.pillarBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillarBottom.TabIndex = 1;
            this.pillarBottom.TabStop = false;
            // 
            // pillarTop
            // 
            this.pillarTop.AccessibleName = "";
            this.pillarTop.Image = global::Flappybird.Properties.Resources.pipedown_1_;
            this.pillarTop.Location = new System.Drawing.Point(434, 2);
            this.pillarTop.Name = "pillarTop";
            this.pillarTop.Size = new System.Drawing.Size(123, 166);
            this.pillarTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillarTop.TabIndex = 0;
            this.pillarTop.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timerEvent);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(572, 600);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pillarBottom);
            this.Controls.Add(this.pillarTop);
            this.Name = "game";
            this.Text = "Game Attempt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillarBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillarTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillarTop;
        private System.Windows.Forms.PictureBox pillarBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer;
    }
}

