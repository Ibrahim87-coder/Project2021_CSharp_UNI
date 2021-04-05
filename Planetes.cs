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
    public partial class Planetes : Form
    {
        int theta = 1000; 
        int[] diametres = { 33, 50, 85, 110, 156, 187, 226, 246, 267 }
        , centreX = { 472, 448, 446, 452, 452, 452, 452, 452, 452 }
        , centreY = { 303, 289, 281, 297, 289, 277, 289, 289, 289 };
        Random r = new Random(); 
        int rand, rand1, rand2, score = 0; 
        string[] names = { "Mercure", "Venus", "La terre", "Mars", "Jupitere", "Satrune", "Uranus", "Neptune", "Pluton" },
        caracteres = { "La plus proche du soleil", "La plus limuneuse dans le ciel", "Ta planete", "Une planete tres chaude", "La plus grande des planetes", "La planete aux anneaux", "La planete a 27 lune", "La planete faite du gaz", "La plus volumineuse du systeme solaire" };
        bool eventChange;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            { 
           
                CheckBox chb = (CheckBox)sender;
                if (chb.TabIndex < 14)
                { 
                    foreach (CheckBox ch in chces1) 
                        if (ch.Checked && ch != chb) 
                            ch.Checked = false;
                } else foreach (CheckBox ch in chces2)
                        if (ch.Checked && ch != chb) 
                            ch.Checked = false;
             //   if ((chb.Text == names[rand]) || (chb.Text == caracteres[rand]) && eventChange) score += 5;c
            //if (chb.Tag.ToString()=="0") o= true; else carCheck = true;
            //    if (carCheck && o)
            //{
            //    theta = 1000;
            //    label3.Text = "Score : " + score;
            //}


            }
        }
        int resolu=0;

        private void wrong1_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            resolu = 0; theta = 0;
            timer1.Start();
            Planetes f = new Planetes();
            f.Show();
            this.Dispose();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            this.Close();
            Variables.science.Show();
            Variables.science.ShowInTaskbar = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            this.Close();
            Variables.science.Show();
            this.ShowInTaskbar = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            eventChange = true;
            theta += 3; 
            pb[rand].Top = -(int)((Math.Cos((theta * 2 * Math.PI) / 360)) * diametres[rand]) + centreY[rand];
            pb[rand].Left = (int)((Math.Sin((theta * 2 * Math.PI) / 360)) * diametres[rand]) + centreX[rand];
            pb[rand].BringToFront(); pictureBox10.BringToFront();
            //chces1[rand1].Text = names[rand];
            //chces2[rand2].Text = caracteres[rand];

            if (theta > 360 + 20 * rand - 150)
            {
                foreach (CheckBox ch in chces1)
                    if ((ch.Text == names[rand])&& ch.Checked && eventChange ) 
                        score += 5;

                foreach (CheckBox ch in chces2) 
                    if (ch.Text == caracteres[rand] && ch.Checked  && eventChange) 
                        score += 5;

                arr.Add(rand);
               
                do 
                {
                    rand2 = r.Next(3);
                    rand1 = r.Next(3);
                } while (rand1 == rand2); 
                
                do 
                {
                    rand = r.Next(9); 
                } while (arr.Contains(rand));
                theta = 0;resolu++;
                eventChange = false;
                chces1[rand1].Checked = false;
                chces2[rand2].Checked = false;
                chces1[rand1].Text = names[rand];

                chces2[rand2].Text = caracteres[rand];
                for (int i = 0; i < 3; i++)
                {
                    if (i != rand1) 
                    {
                        chces1[i].Text = names[r.Next(9)]; 
                    }
                    if (i != rand2)
                    { 
                        chces2[i].Text = caracteres[r.Next(9)];
                    }
                    chces1[i].Checked = false;
                    chces2[i].Checked = false;
                    label3.Text = "Score : " + score;
                }
            }
            if (resolu == 8)
            { 
                panel1.Visible = true;
                panel1.BringToFront(); 
                if (score > 40) 
                { 
                    true1.Visible = true; 
                    wrong1.Visible = false; 
                } else 
                { 
                    true1.Visible= false;
                    wrong1.Visible  = true; 
                }
            }
            label4.Text  = "Ton score est: " + score.ToString();label4.Visible = true;
        }

        List<int> arr = new List<int>(); 
        PictureBox[] pb = new PictureBox[9];

        CheckBox[] chces1 = new CheckBox[3], chces2 = new CheckBox[3];
        

        public Planetes()
        {
            InitializeComponent(); rand = r.Next(9); rand2 = r.Next(3); rand1 = r.Next(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = Application.StartupPath + "\\Pics\\9planete.png";
            pictureBox8.ImageLocation = Application.StartupPath + "\\Pics\\8planete.png";
            pictureBox7.ImageLocation = Application.StartupPath + "\\Pics\\7planete.png";
            pictureBox6.ImageLocation = Application.StartupPath + "\\Pics\\6planete.png";
            pictureBox5.ImageLocation = Application.StartupPath + "\\Pics\\5planete.png";
            pictureBox4.ImageLocation = Application.StartupPath + "\\Pics\\4planete.png";
            pictureBox2.ImageLocation = Application.StartupPath + "\\Pics\\3planete.png";
            pictureBox1.ImageLocation = Application.StartupPath + "\\Pics\\2planete.png";
            pictureBox3.ImageLocation = Application.StartupPath + "\\Pics\\1planete.png";
            pictureBox10.ImageLocation = Application.StartupPath + "\\Pics\\soleil.png";
            timer1.Start(); 
            pb[0] = pictureBox9;
            pb[1] = pictureBox8;
            pb[2] = pictureBox7;
            pb[3] = pictureBox6;
            pb[4] = pictureBox5;
            pb[5] = pictureBox4; 
            pb[6] = pictureBox2;
            pb[7] = pictureBox1;
            pb[8] = pictureBox3;
            chces1[0] = checkBox1; 
            chces1[1] = checkBox2; 
            chces1[2] = checkBox3; 
            chces2[0] = checkBox4;
            chces2[1] = checkBox5; 
            chces2[2] = checkBox6;


        }
    }
}
