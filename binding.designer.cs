
namespace Start
{
    partial class binding
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
            this.comfirmerB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comfirmerB
            // 
            this.comfirmerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comfirmerB.FlatAppearance.BorderSize = 0;
            this.comfirmerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comfirmerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmerB.ForeColor = System.Drawing.Color.White;
            this.comfirmerB.Location = new System.Drawing.Point(638, 387);
            this.comfirmerB.Name = "comfirmerB";
            this.comfirmerB.Size = new System.Drawing.Size(176, 60);
            this.comfirmerB.TabIndex = 1;
            this.comfirmerB.Text = "Confirmer";
            this.comfirmerB.UseVisualStyleBackColor = true;
            this.comfirmerB.Click += new System.EventHandler(this.comfirmerB_Click);
            // 
            // binding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comfirmerB);
            this.Name = "binding";
            this.Size = new System.Drawing.Size(940, 485);
            this.Load += new System.EventHandler(this.binding_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.binding_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button comfirmerB;
    }
}
