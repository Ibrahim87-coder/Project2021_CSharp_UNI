using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Start
{
    public partial class Coloriage2 : Form
    {
        Graphics g ; int x = -1, y = -1, i = 0; float w; bool moving, erase; Pen p; Color clr = Color.Lime;int[] nature = { 1,2};
        public Coloriage2()
        {
            
            InitializeComponent();
           
            g = pictureBox11.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        }
     
        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false; x = -1; y = -1;

        }
        Bitmap b;Color c;
        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            b = (Bitmap)pictureBox11.Image;
            try { c = b.GetPixel(e.X, e.Y); } catch { }
            if (erase)
            {

                try { g.DrawLine(new Pen(c), new Point(e.X, e.Y), new Point(e.X + 1, e.Y + 1)); g.DrawEllipse(new Pen(c), new Rectangle(e.X + i, e.Y + i, 1, 1)); } catch { }
                try { c = b.GetPixel(e.X + 1, e.Y + 1); g.DrawLine(new Pen(c), new Point(e.X + 1, e.Y + 1), new Point(e.X + 2, e.Y + 2)); } catch { }
                try
                {
                    c = b.GetPixel(e.X + 2, e.Y + 2); g.DrawLine(new Pen(c), new Point(e.X + 2, e.Y + 2), new Point(e.X + 3, e.Y + 3));
                }
                catch { }
                g.DrawLine(new Pen(c), new Point(e.X + i, e.Y + i), new Point(e.X + i + 1, e.Y + i + 1));
            }

            // i f (erase) g.Clear(c);
            else if (moving && x != -1 && y != -1)

            {
                try { g.DrawLine(p, new Point(x, y), e.Location); } catch { }
                x = e.X; y = e.Y;
            }
           
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true; x = e.X; y = e.Y;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            clr = Color.Blue; p.Click += pictureBox3_Click_1;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            PictureBox p= (PictureBox)sender;
            clr = Color.Purple; p .Click += pictureBox3_Click_1;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            PictureBox p= (PictureBox)sender;
            clr = Color.Navy; p.Click+= pictureBox3_Click_1;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            clr = Color.Red; p.Click += pictureBox3_Click_1;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            PictureBox p= (PictureBox)sender;
            clr = Color.Yellow; p.Click += pictureBox3_Click_1;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            clr = Color.Green; p.Click += pictureBox3_Click_1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            i++; if (i == 2) i = 0;
            changerCrayons();
            pictureBox20.Visible = true;
            pictureBox20.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox19.ImageLocation = Application.StartupPath + "\\Pics\\1pen.png";
            pictureBox18.ImageLocation = Application.StartupPath + "\\Pics\\2pen.png";
            pictureBox13.ImageLocation = Application.StartupPath + "\\Pics\\3pen.png";
            pictureBox14.ImageLocation = Application.StartupPath + "\\Pics\\4pen.png";
            pictureBox17.ImageLocation = Application.StartupPath + "\\Pics\\5pen.png";
            pictureBox16.ImageLocation = Application.StartupPath + "\\Pics\\6pen.png";
            pictureBox15.ImageLocation = Application.StartupPath + "\\Pics\\7pen.png";
            pictureBox3.ImageLocation = Application.StartupPath + "\\Pics\\1br.png";
            pictureBox4.ImageLocation = Application.StartupPath + "\\Pics\\2br.png";
            pictureBox9.ImageLocation = Application.StartupPath + "\\Pics\\3br.png";
            pictureBox8.ImageLocation = Application.StartupPath + "\\Pics\\4br.png";
            pictureBox5.ImageLocation = Application.StartupPath + "\\Pics\\5br.png";
            pictureBox6.ImageLocation = Application.StartupPath + "\\Pics\\6br.png";
            pictureBox7.ImageLocation = Application.StartupPath + "\\Pics\\7br.png";
            pictureBox10.ImageLocation = Application.StartupPath + "\\Pics\\palette.png";
            pictureBox1.ImageLocation = Application.StartupPath + "\\Pics\\cadre en bois.png";
            pictureBox20.ImageLocation = Application.StartupPath + "\\Pics\\trash_500px.png";
            pictureBox12.ImageLocation = pictureBox2.ImageLocation = Application.StartupPath + "\\Pics\\pic.png";
        }
        public static Bitmap drawControlToBitmap(Control cont)
        {
            Bitmap bit = new Bitmap(cont.Width, cont.Height);
            Graphics grap = Graphics.FromImage(bit);
            Rectangle rect = cont.RectangleToScreen(cont.ClientRectangle);
            grap.CopyFromScreen(rect.Location, Point.Empty, cont.Size);
            return bit;
            
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Bitmap b = drawControlToBitmap(pictureBox11);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if(sf.ShowDialog()==DialogResult.OK)
            {
               b.Save(sf.FileName );
            }
           // System.Diagnostics.Process.Start(sf.FileName);
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            x = -1; 
            y = -1; 
            i = 0; 
            Color clr = Color.Lime;
            panel1.Visible = panel3.Visible = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
        //    if (erase) this.Cursor = new Cursor(Application.StartupPath + "\\Pics\\1pen.png");
        //  else this.Cursor = Cursors.Default;
        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Variables.Jeux.Show();
            Variables.Jeux.ShowInTaskbar = true;
        }

        private void pictureBox23_Click_1(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Bitmap b = drawControlToBitmap(pictureBox11);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
              
                b.Save(sf.FileName);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Empty);
            pictureBox11.Image = b;
        }

        Panel pnl;
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            erase = false;
            if (i == 1) pnl = panel1; if (i == 0) pnl = panel3;
            foreach (Control c in pnl.Controls)
            {
                if ((string)c.Tag == "Choisi") 
                {
                    c.Left += 25; c.Tag = "";
                }
            }
            PictureBox pbox = (PictureBox)sender;
            pbox.Left -= 25; pbox.Tag = "Choisi";
            if (pbox == pictureBox19) clr = Color.Orange;
            if (pbox == pictureBox3) clr = Color.Lime;
            //if(pbox==pictureBox20 || pbox == pictureBox21) clr=pictureBox1                      
            p = new Pen(clr, w);

            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;


        }
        public void changerCrayons()
        {
            if (i == 1) pnl = panel1; if (i == 0) pnl = panel3;
            foreach (Control c in pnl.Controls) { if ((string)c.Tag == "Choisi") { c.Left += 25; c.Tag = ""; } }
           
            if (i == 1) { panel3.Visible = false; panel1.Visible=true; panel1.BringToFront(); w =(float) 7.5; }
          //  if (i == 2) { panel1.Visible=false; panel3.Visible=true;panel3.BringToFront(); w = 1; }
            if (i == 0)
            {
                panel1.Visible = false; panel3.Visible = true;panel1.SendToBack(); panel3.BringToFront(); w = 1;
            }
            pictureBox10.BringToFront();
        }
    }
}
