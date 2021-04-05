using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Coloriage : Form
    {
        Coloriage2 f= new Coloriage2() ;
        Graphics g; Pen p; Color clr = Color.Lime;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Coloriage_Load(object sender, EventArgs e)
        {   pictureBox1.ImageLocation= Application.StartupPath + "\\Pics\\board.png";
            pictureBox3.ImageLocation = Application.StartupPath + "\\Pics\\1D.jpg";
            pictureBox2.ImageLocation = Application.StartupPath + "\\Pics\\2D.jpg";
            pictureBox4.ImageLocation = Application.StartupPath + "\\Pics\\3D.jpg";
            pictureBox5.ImageLocation = Application.StartupPath + "\\Pics\\4D.jpg";
            pictureBox6.ImageLocation = Application.StartupPath + "\\Pics\\5D.jpg";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = Application.StartupPath + "\\Pics\\6D.jpg";
            pictureBox2.ImageLocation = Application.StartupPath + "\\Pics\\7D.jpg";
            pictureBox4.ImageLocation = Application.StartupPath + "\\Pics\\8D.jpg";
            pictureBox5.ImageLocation = Application.StartupPath + "\\Pics\\9D.jpg";
            pictureBox6.ImageLocation = Application.StartupPath + "\\Pics\\10D.jpg";
            pictureBox9.Visible = true; pictureBox8.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            pictureBox3.ImageLocation = Application.StartupPath + "\\Pics\\1D.jpg";
            pictureBox2.ImageLocation = Application.StartupPath + "\\Pics\\2D.jpg";
            pictureBox4.ImageLocation = Application.StartupPath + "\\Pics\\3D.jpg";
            pictureBox5.ImageLocation = Application.StartupPath + "\\Pics\\4D.jpg";
            pictureBox6.ImageLocation = Application.StartupPath + "\\Pics\\5D.jpg";
            pictureBox8.Visible = true;pictureBox9.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            

            f.Close();
            this.Close();
            Variables.Jeux.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        public Coloriage()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            p = new Pen(clr, 0);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pbox = (PictureBox)sender;
       
            f.Show();
            f.pictureBox11.Image = pbox.Image ;
        }
    }
}
