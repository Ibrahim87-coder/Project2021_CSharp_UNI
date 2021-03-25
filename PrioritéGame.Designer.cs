namespace Start
{
    partial class jeux_de_Priorité
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jeux_de_Priorité));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSuivant = new System.Windows.Forms.Label();
            this.Suivant = new System.Windows.Forms.PictureBox();
            this.txtOperation = new System.Windows.Forms.Label();
            this.reponse4 = new System.Windows.Forms.Button();
            this.reponse3 = new System.Windows.Forms.Button();
            this.reponse2 = new System.Windows.Forms.Button();
            this.reponse1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HighScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblSuivant);
            this.panel1.Controls.Add(this.Suivant);
            this.panel1.Controls.Add(this.txtOperation);
            this.panel1.Controls.Add(this.reponse4);
            this.panel1.Controls.Add(this.reponse3);
            this.panel1.Controls.Add(this.reponse2);
            this.panel1.Controls.Add(this.reponse1);
            this.panel1.Location = new System.Drawing.Point(498, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 562);
            this.panel1.TabIndex = 0;
            // 
            // lblSuivant
            // 
            this.lblSuivant.AutoSize = true;
            this.lblSuivant.BackColor = System.Drawing.Color.Transparent;
            this.lblSuivant.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuivant.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSuivant.Location = new System.Drawing.Point(630, 197);
            this.lblSuivant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuivant.Name = "lblSuivant";
            this.lblSuivant.Size = new System.Drawing.Size(135, 35);
            this.lblSuivant.TabIndex = 6;
            this.lblSuivant.Text = "Suivant";
            this.lblSuivant.Visible = false;
            // 
            // Suivant
            // 
            this.Suivant.BackColor = System.Drawing.Color.Transparent;
            this.Suivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suivant.Image = ((System.Drawing.Image)(resources.GetObject("Suivant.Image")));
            this.Suivant.Location = new System.Drawing.Point(660, 235);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(77, 67);
            this.Suivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Suivant.TabIndex = 6;
            this.Suivant.TabStop = false;
            this.Suivant.Visible = false;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // txtOperation
            // 
            this.txtOperation.AutoSize = true;
            this.txtOperation.BackColor = System.Drawing.Color.Transparent;
            this.txtOperation.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperation.Location = new System.Drawing.Point(355, 147);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(37, 50);
            this.txtOperation.TabIndex = 5;
            this.txtOperation.Text = "x";
            // 
            // reponse4
            // 
            this.reponse4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.reponse4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reponse4.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.reponse4.FlatAppearance.BorderSize = 3;
            this.reponse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse4.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse4.ForeColor = System.Drawing.Color.White;
            this.reponse4.Location = new System.Drawing.Point(641, 338);
            this.reponse4.Name = "reponse4";
            this.reponse4.Size = new System.Drawing.Size(96, 50);
            this.reponse4.TabIndex = 4;
            this.reponse4.UseVisualStyleBackColor = false;
            this.reponse4.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // reponse3
            // 
            this.reponse3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.reponse3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reponse3.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.reponse3.FlatAppearance.BorderSize = 3;
            this.reponse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse3.ForeColor = System.Drawing.Color.White;
            this.reponse3.Location = new System.Drawing.Point(503, 338);
            this.reponse3.Name = "reponse3";
            this.reponse3.Size = new System.Drawing.Size(96, 50);
            this.reponse3.TabIndex = 3;
            this.reponse3.UseVisualStyleBackColor = false;
            this.reponse3.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // reponse2
            // 
            this.reponse2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.reponse2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reponse2.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.reponse2.FlatAppearance.BorderSize = 3;
            this.reponse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse2.ForeColor = System.Drawing.Color.White;
            this.reponse2.Location = new System.Drawing.Point(355, 338);
            this.reponse2.Name = "reponse2";
            this.reponse2.Size = new System.Drawing.Size(96, 50);
            this.reponse2.TabIndex = 2;
            this.reponse2.UseVisualStyleBackColor = false;
            this.reponse2.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // reponse1
            // 
            this.reponse1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.reponse1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reponse1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.reponse1.FlatAppearance.BorderSize = 3;
            this.reponse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse1.ForeColor = System.Drawing.Color.White;
            this.reponse1.Location = new System.Drawing.Point(219, 338);
            this.reponse1.Name = "reponse1";
            this.reponse1.Size = new System.Drawing.Size(96, 50);
            this.reponse1.TabIndex = 1;
            this.reponse1.UseVisualStyleBackColor = false;
            this.reponse1.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScore.Location = new System.Drawing.Point(138, 330);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(174, 42);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score : 0";
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
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HighScore.Location = new System.Drawing.Point(74, 226);
            this.HighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(325, 42);
            this.HighScore.TabIndex = 57;
            this.HighScore.Text = "meilleur score: 0";
            // 
            // jeux_de_Priorité
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 727);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jeux_de_Priorité";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jeux_de_Priorité";
            this.Load += new System.EventHandler(this.PrioritéGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suivant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reponse4;
        private System.Windows.Forms.Button reponse3;
        private System.Windows.Forms.Button reponse2;
        private System.Windows.Forms.Button reponse1;
        private System.Windows.Forms.Label txtOperation;
        private System.Windows.Forms.PictureBox Suivant;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSuivant;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HighScore;
    }
}