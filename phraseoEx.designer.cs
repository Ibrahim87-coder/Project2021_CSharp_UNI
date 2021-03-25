
namespace Start
{
    partial class phraseoEx
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phraseoEx));
            this.comfirmerB = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comfirmerB
            // 
            this.comfirmerB.FlatAppearance.BorderSize = 0;
            this.comfirmerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comfirmerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmerB.ForeColor = System.Drawing.Color.Black;
            this.comfirmerB.Location = new System.Drawing.Point(308, 531);
            this.comfirmerB.Name = "comfirmerB";
            this.comfirmerB.Size = new System.Drawing.Size(139, 60);
            this.comfirmerB.TabIndex = 0;
            this.comfirmerB.Text = "Confirmer";
            this.comfirmerB.UseVisualStyleBackColor = true;
            this.comfirmerB.Click += new System.EventHandler(this.comfirmerB_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(787, 611);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(120, 32);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.FlatAppearance.BorderSize = 0;
            this.nxtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtBtn.ForeColor = System.Drawing.Color.Black;
            this.nxtBtn.Location = new System.Drawing.Point(718, 531);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(139, 60);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Suivant";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // phraseoEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.comfirmerB);
            this.Name = "phraseoEx";
            this.Size = new System.Drawing.Size(1326, 727);
            this.Load += new System.EventHandler(this.phraseoEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comfirmerB;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
