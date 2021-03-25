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
    public partial class jeux_de_heure : Form
    {
        public jeux_de_heure()
        {
            
            InitializeComponent();
            score = 0;
            for (int i = 0; i < 20; i++)
            {
                imageList1.Images[i].Tag = i.ToString();
            }
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
        }
        PictureBox clock;
        int a, score;

        public static int niveau;
        DataRow[] dr;
        public string CheckWichClock(PictureBox b)
        {
            if (b.Image.Tag.ToString() == 0.ToString())
                return "1:30";
            else if (b.Image.Tag.ToString() == 1.ToString())
                return "2:40";
            else if (b.Image.Tag.ToString() == 2.ToString())
                return "2:00";
            else if (b.Image.Tag.ToString() == 3.ToString())
                return "4:15";
            else if (b.Image.Tag.ToString() == 4.ToString())
                return "4:35";
            else if (b.Image.Tag.ToString() == 5.ToString())
                return "4:45";
            else if (b.Image.Tag.ToString() == 6.ToString())
                return "5:20";
            else if (b.Image.Tag.ToString() == 7.ToString())
                return "5:50";
            else if (b.Image.Tag.ToString() == 8.ToString())
                return "6:15";
            else if (b.Image.Tag.ToString() == 9.ToString())
                return "6:00";
            else if (b.Image.Tag.ToString() == 10.ToString())
                return "7:05";
            else if (b.Image.Tag.ToString() == 11.ToString())
                return "7:40";
            else if (b.Image.Tag.ToString() == 12.ToString())
                return "9:20";
            else if (b.Image.Tag.ToString() == 13.ToString())
                return "10:35";
            else if (b.Image.Tag.ToString() == 14.ToString())
                return "10:40";
            else if (b.Image.Tag.ToString() == 15.ToString())
                return "10:45";
            else if (b.Image.Tag.ToString() == 16.ToString())
                return "11:10";
            else if (b.Image.Tag.ToString() == 17.ToString())
                return "11:45";
            else if (b.Image.Tag.ToString() == 18.ToString())
                return "12:50";
            else if (b.Image.Tag.ToString() == 19.ToString())
                return "2:00";
            else return "nothing";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
      
            
                label1.Text = "meilleur Score : " + dr[0]["Clock"];
                label1.Visible = true;
            

            Random r1 = new Random();
            clock = new PictureBox();

            {
                a = r1.Next(0, 20);
                clock.Name = "piz3";
              
                clock.Size = new Size(300, 300);
                clock.BringToFront();
                clock.Location = new Point(28, 30);
                clock.Visible = true;
               
                clock.Image = imageList1.Images[a];
                clock.BackColor = Color.Transparent;
                clock.SizeMode = PictureBoxSizeMode.StretchImage;
            };
            panel1.Controls.Add(clock);
            clock.Image.Tag = a;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Clock"].ToString()) < score)
            {
                dr[0]["Clock"] = score; 
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (int.Parse(dr[0]["Clock"].ToString()) < score)
            {
                dr[0]["Clock"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (score < 3)
            {
                if (textBox1.Text == CheckWichClock(clock))
                {
                    score+=10;
                    scoretxt.Text = "Score: " + score.ToString();
                    Faux.Visible = false;
                    Random ri = new Random();
                    int ai = ri.Next(0, 20);
                    clock.Image = imageList1.Images[ai];
                    clock.Image.Tag = ai;
                    textBox1.Clear();

                }
                else
                {
                    Faux.Visible = true;
                }
            }
            else
            {
                niveau++; 
                dr[0]["Clock"] = niveau + 1;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");score = 0;
                
            }
        }
    }
}
