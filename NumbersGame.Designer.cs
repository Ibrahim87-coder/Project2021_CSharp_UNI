namespace Start
{
    partial class NumbersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumbersGame));
            this.nb1 = new System.Windows.Forms.PictureBox();
            this.nb2 = new System.Windows.Forms.PictureBox();
            this.nb3 = new System.Windows.Forms.PictureBox();
            this.labelNb = new System.Windows.Forms.Label();
            this.labelTaper = new System.Windows.Forms.Label();
            this.ImageNb = new System.Windows.Forms.ImageList(this.components);
            this.timerNb = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HighScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.nb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // nb1
            // 
            this.nb1.BackColor = System.Drawing.Color.Transparent;
            this.nb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nb1.Image = ((System.Drawing.Image)(resources.GetObject("nb1.Image")));
            this.nb1.Location = new System.Drawing.Point(185, 225);
            this.nb1.Name = "nb1";
            this.nb1.Size = new System.Drawing.Size(272, 249);
            this.nb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nb1.TabIndex = 0;
            this.nb1.TabStop = false;
            this.nb1.Click += new System.EventHandler(this.nb1_Click);
            // 
            // nb2
            // 
            this.nb2.BackColor = System.Drawing.Color.Transparent;
            this.nb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nb2.Location = new System.Drawing.Point(592, 225);
            this.nb2.Name = "nb2";
            this.nb2.Size = new System.Drawing.Size(272, 249);
            this.nb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nb2.TabIndex = 1;
            this.nb2.TabStop = false;
            this.nb2.Click += new System.EventHandler(this.nb1_Click);
            // 
            // nb3
            // 
            this.nb3.BackColor = System.Drawing.Color.Transparent;
            this.nb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nb3.Location = new System.Drawing.Point(968, 225);
            this.nb3.Name = "nb3";
            this.nb3.Size = new System.Drawing.Size(272, 249);
            this.nb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nb3.TabIndex = 2;
            this.nb3.TabStop = false;
            this.nb3.Click += new System.EventHandler(this.nb1_Click);
            // 
            // labelNb
            // 
            this.labelNb.AutoSize = true;
            this.labelNb.BackColor = System.Drawing.Color.Transparent;
            this.labelNb.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNb.ForeColor = System.Drawing.Color.Magenta;
            this.labelNb.Location = new System.Drawing.Point(744, 57);
            this.labelNb.Name = "labelNb";
            this.labelNb.Size = new System.Drawing.Size(87, 91);
            this.labelNb.TabIndex = 3;
            this.labelNb.Text = "1";
            // 
            // labelTaper
            // 
            this.labelTaper.AutoSize = true;
            this.labelTaper.BackColor = System.Drawing.Color.Transparent;
            this.labelTaper.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaper.ForeColor = System.Drawing.Color.Magenta;
            this.labelTaper.Location = new System.Drawing.Point(398, 57);
            this.labelTaper.Name = "labelTaper";
            this.labelTaper.Size = new System.Drawing.Size(278, 91);
            this.labelTaper.TabIndex = 4;
            this.labelTaper.Text = "Taper";
            // 
            // ImageNb
            // 
            this.ImageNb.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageNb.ImageStream")));
            this.ImageNb.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageNb.Images.SetKeyName(0, "1.gif");
            this.ImageNb.Images.SetKeyName(1, "2.gif");
            this.ImageNb.Images.SetKeyName(2, "3.gif");
            this.ImageNb.Images.SetKeyName(3, "4.gif");
            this.ImageNb.Images.SetKeyName(4, "5.gif");
            this.ImageNb.Images.SetKeyName(5, "6.gif");
            this.ImageNb.Images.SetKeyName(6, "7.gif");
            this.ImageNb.Images.SetKeyName(7, "8.gif");
            this.ImageNb.Images.SetKeyName(8, "9.gif");
            this.ImageNb.Images.SetKeyName(9, "10.gif");
            // 
            // timerNb
            // 
            this.timerNb.Interval = 3000;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Aqua;
            this.score.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Magenta;
            this.score.Location = new System.Drawing.Point(102, 613);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(358, 91);
            this.score.TabIndex = 5;
            this.score.Text = "Score: 0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1281, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 33;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Aqua;
            this.HighScore.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.Color.Magenta;
            this.HighScore.Location = new System.Drawing.Point(25, 148);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(403, 49);
            this.HighScore.TabIndex = 58;
            this.HighScore.Text = "meilleur Score : 0";
            this.HighScore.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.mediaplayer);
            this.panel1.Location = new System.Drawing.Point(954, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 66);
            this.panel1.TabIndex = 59;
            this.panel1.Visible = false;
            // 
            // mediaplayer
            // 
            this.mediaplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(0, 0);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(53, 66);
            this.mediaplayer.TabIndex = 58;
            this.mediaplayer.Visible = false;
            // 
            // NumbersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.score);
            this.Controls.Add(this.labelTaper);
            this.Controls.Add(this.labelNb);
            this.Controls.Add(this.nb3);
            this.Controls.Add(this.nb2);
            this.Controls.Add(this.nb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumbersGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jeux des nombres";
            this.Load += new System.EventHandler(this.NumbersGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nb1;
        private System.Windows.Forms.PictureBox nb2;
        private System.Windows.Forms.PictureBox nb3;
        private System.Windows.Forms.Label labelNb;
        private System.Windows.Forms.Label labelTaper;
        private System.Windows.Forms.ImageList ImageNb;
        private System.Windows.Forms.Timer timerNb;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
    }
}