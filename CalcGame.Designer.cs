namespace Start
{
    partial class jeux_de_Calcule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jeux_de_Calcule));
            this.planePic = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.GameBack = new System.Windows.Forms.Panel();
            this.Over = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.Label();
            this.cloudOp = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Life3 = new System.Windows.Forms.PictureBox();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.HGNB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RestartGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planePic)).BeginInit();
            this.GameBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloudOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartGame)).BeginInit();
            this.SuspendLayout();
            // 
            // planePic
            // 
            this.planePic.BackColor = System.Drawing.Color.Transparent;
            this.planePic.Image = ((System.Drawing.Image)(resources.GetObject("planePic.Image")));
            this.planePic.Location = new System.Drawing.Point(33, 50);
            this.planePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planePic.Name = "planePic";
            this.planePic.Size = new System.Drawing.Size(172, 112);
            this.planePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planePic.TabIndex = 1;
            this.planePic.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 10;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // GameBack
            // 
            this.GameBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameBack.BackgroundImage")));
            this.GameBack.Controls.Add(this.Over);
            this.GameBack.Controls.Add(this.op);
            this.GameBack.Controls.Add(this.cloudOp);
            this.GameBack.Controls.Add(this.planePic);
            this.GameBack.Location = new System.Drawing.Point(451, 101);
            this.GameBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameBack.Name = "GameBack";
            this.GameBack.Size = new System.Drawing.Size(900, 635);
            this.GameBack.TabIndex = 2;
            // 
            // Over
            // 
            this.Over.AutoSize = true;
            this.Over.BackColor = System.Drawing.Color.Transparent;
            this.Over.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Over.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Over.Location = new System.Drawing.Point(231, 263);
            this.Over.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(435, 69);
            this.Over.TabIndex = 8;
            this.Over.Text = "Game Over !!!";
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.op.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op.Location = new System.Drawing.Point(704, 189);
            this.op.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(0, 35);
            this.op.TabIndex = 3;
            // 
            // cloudOp
            // 
            this.cloudOp.BackColor = System.Drawing.Color.Transparent;
            this.cloudOp.Image = ((System.Drawing.Image)(resources.GetObject("cloudOp.Image")));
            this.cloudOp.Location = new System.Drawing.Point(644, 151);
            this.cloudOp.Margin = new System.Windows.Forms.Padding(4);
            this.cloudOp.Name = "cloudOp";
            this.cloudOp.Size = new System.Drawing.Size(163, 98);
            this.cloudOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudOp.TabIndex = 2;
            this.cloudOp.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScore.Location = new System.Drawing.Point(120, 436);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(174, 42);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score : 0";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblTarget.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(192, 234);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(0, 91);
            this.lblTarget.TabIndex = 4;
            // 
            // Life1
            // 
            this.Life1.Image = ((System.Drawing.Image)(resources.GetObject("Life1.Image")));
            this.Life1.Location = new System.Drawing.Point(73, 132);
            this.Life1.Margin = new System.Windows.Forms.Padding(4);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(81, 65);
            this.Life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life1.TabIndex = 5;
            this.Life1.TabStop = false;
            // 
            // Life3
            // 
            this.Life3.Image = ((System.Drawing.Image)(resources.GetObject("Life3.Image")));
            this.Life3.Location = new System.Drawing.Point(252, 133);
            this.Life3.Margin = new System.Windows.Forms.Padding(4);
            this.Life3.Name = "Life3";
            this.Life3.Size = new System.Drawing.Size(81, 65);
            this.Life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life3.TabIndex = 6;
            this.Life3.TabStop = false;
            // 
            // Life2
            // 
            this.Life2.Image = ((System.Drawing.Image)(resources.GetObject("Life2.Image")));
            this.Life2.Location = new System.Drawing.Point(163, 133);
            this.Life2.Margin = new System.Windows.Forms.Padding(4);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(81, 65);
            this.Life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life2.TabIndex = 7;
            this.Life2.TabStop = false;
            // 
            // HGNB
            // 
            this.HGNB.AutoSize = true;
            this.HGNB.BackColor = System.Drawing.Color.Transparent;
            this.HGNB.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HGNB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HGNB.Location = new System.Drawing.Point(59, 351);
            this.HGNB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HGNB.Name = "HGNB";
            this.HGNB.Size = new System.Drawing.Size(340, 42);
            this.HGNB.TabIndex = 9;
            this.HGNB.Text = "meilleur Score : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Start.Properties.Resources.exit_sign_480px;
            this.pictureBox3.Location = new System.Drawing.Point(1278, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(121, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 61;
            this.label1.Text = "Rejouer";
            // 
            // RestartGame
            // 
            this.RestartGame.BackColor = System.Drawing.Color.Transparent;
            this.RestartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartGame.Image = ((System.Drawing.Image)(resources.GetObject("RestartGame.Image")));
            this.RestartGame.Location = new System.Drawing.Point(144, 529);
            this.RestartGame.Name = "RestartGame";
            this.RestartGame.Size = new System.Drawing.Size(110, 97);
            this.RestartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestartGame.TabIndex = 60;
            this.RestartGame.TabStop = false;
            this.RestartGame.Click += new System.EventHandler(this.RestartGame_Click);
            // 
            // jeux_de_Calcule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartGame);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HGNB);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.Life3);
            this.Controls.Add(this.Life1);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.GameBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "jeux_de_Calcule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jeux_de_Calcule";
            this.Load += new System.EventHandler(this.CalcGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalcGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.planePic)).EndInit();
            this.GameBack.ResumeLayout(false);
            this.GameBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloudOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planePic;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Panel GameBack;
        private System.Windows.Forms.PictureBox cloudOp;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.PictureBox Life1;
        private System.Windows.Forms.PictureBox Life3;
        private System.Windows.Forms.PictureBox Life2;
        private System.Windows.Forms.Label Over;
        private System.Windows.Forms.Label HGNB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RestartGame;
    }
}