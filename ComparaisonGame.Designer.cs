namespace Start
{
    partial class Jeux_de_comparaison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeux_de_comparaison));
            this.NBGrand = new System.Windows.Forms.PictureBox();
            this.NbPetit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NB2 = new System.Windows.Forms.Button();
            this.NB1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Quest = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.PictureBox();
            this.HelpPic = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.HighScore = new System.Windows.Forms.Label();
            this.Helppic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NBGrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPetit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helppic2)).BeginInit();
            this.SuspendLayout();
            // 
            // NBGrand
            // 
            this.NBGrand.BackColor = System.Drawing.Color.Fuchsia;
            this.NBGrand.Location = new System.Drawing.Point(6, 97);
            this.NBGrand.Name = "NBGrand";
            this.NBGrand.Size = new System.Drawing.Size(320, 309);
            this.NBGrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NBGrand.TabIndex = 0;
            this.NBGrand.TabStop = false;
            // 
            // NbPetit
            // 
            this.NbPetit.BackColor = System.Drawing.Color.Fuchsia;
            this.NbPetit.Location = new System.Drawing.Point(493, 97);
            this.NbPetit.Name = "NbPetit";
            this.NbPetit.Size = new System.Drawing.Size(320, 309);
            this.NbPetit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NbPetit.TabIndex = 1;
            this.NbPetit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.NB2);
            this.panel1.Controls.Add(this.NB1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Quest);
            this.panel1.Controls.Add(this.NBGrand);
            this.panel1.Controls.Add(this.NbPetit);
            this.panel1.Location = new System.Drawing.Point(509, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 539);
            this.panel1.TabIndex = 2;
            // 
            // NB2
            // 
            this.NB2.BackColor = System.Drawing.Color.Indigo;
            this.NB2.Enabled = false;
            this.NB2.Font = new System.Drawing.Font("Romantic", 34F, System.Drawing.FontStyle.Bold);
            this.NB2.ForeColor = System.Drawing.Color.White;
            this.NB2.Location = new System.Drawing.Point(590, 0);
            this.NB2.Name = "NB2";
            this.NB2.Size = new System.Drawing.Size(110, 95);
            this.NB2.TabIndex = 7;
            this.NB2.Text = "0";
            this.NB2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NB2.UseVisualStyleBackColor = false;
            // 
            // NB1
            // 
            this.NB1.BackColor = System.Drawing.Color.Indigo;
            this.NB1.Enabled = false;
            this.NB1.Font = new System.Drawing.Font("Romantic", 34F, System.Drawing.FontStyle.Bold);
            this.NB1.ForeColor = System.Drawing.Color.White;
            this.NB1.Location = new System.Drawing.Point(96, 0);
            this.NB1.Name = "NB1";
            this.NB1.Size = new System.Drawing.Size(110, 95);
            this.NB1.TabIndex = 6;
            this.NB1.Text = "1";
            this.NB1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NB1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(346, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(606, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quest
            // 
            this.Quest.BackColor = System.Drawing.Color.Transparent;
            this.Quest.InitialImage = ((System.Drawing.Image)(resources.GetObject("Quest.InitialImage")));
            this.Quest.Location = new System.Drawing.Point(332, 191);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(157, 146);
            this.Quest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Quest.TabIndex = 2;
            this.Quest.TabStop = false;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.Location = new System.Drawing.Point(180, 265);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(141, 139);
            this.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Help.TabIndex = 8;
            this.Help.TabStop = false;
            this.Help.MouseEnter += new System.EventHandler(this.Help_MouseEnter);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            // 
            // HelpPic
            // 
            this.HelpPic.Image = ((System.Drawing.Image)(resources.GetObject("HelpPic.Image")));
            this.HelpPic.Location = new System.Drawing.Point(43, 420);
            this.HelpPic.Name = "HelpPic";
            this.HelpPic.Size = new System.Drawing.Size(210, 270);
            this.HelpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpPic.TabIndex = 9;
            this.HelpPic.TabStop = false;
            this.HelpPic.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScore.Location = new System.Drawing.Point(161, 220);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(174, 42);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score : 0";
            // 
            // TimerGame
            // 
            this.TimerGame.Interval = 3000;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "11.jpg");
            this.imageList1.Images.SetKeyName(1, "22.jpg");
            this.imageList1.Images.SetKeyName(2, "33.jpg");
            this.imageList1.Images.SetKeyName(3, "Quest.png");
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HighScore.Location = new System.Drawing.Point(80, 149);
            this.HighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(340, 42);
            this.HighScore.TabIndex = 57;
            this.HighScore.Text = "meilleur Score : 0";
            // 
            // Helppic2
            // 
            this.Helppic2.Image = ((System.Drawing.Image)(resources.GetObject("Helppic2.Image")));
            this.Helppic2.Location = new System.Drawing.Point(259, 420);
            this.Helppic2.Name = "Helppic2";
            this.Helppic2.Size = new System.Drawing.Size(210, 270);
            this.Helppic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Helppic2.TabIndex = 58;
            this.Helppic2.TabStop = false;
            this.Helppic2.Visible = false;
            // 
            // Jeux_de_comparaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1360, 727);
            this.Controls.Add(this.Helppic2);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.HelpPic);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeux_de_comparaison";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeux_de_comparaison";
            this.Load += new System.EventHandler(this.ComparaisonGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBGrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPetit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helppic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NBGrand;
        private System.Windows.Forms.PictureBox NbPetit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Quest;
        private System.Windows.Forms.Button NB1;
        private System.Windows.Forms.Button NB2;
        private System.Windows.Forms.PictureBox Help;
        private System.Windows.Forms.PictureBox HelpPic;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.PictureBox Helppic2;
    }
}