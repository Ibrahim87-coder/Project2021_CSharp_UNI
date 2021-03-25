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
    public partial class jeux_de_ecriture : Form
    {
        Panel[] panels = new Panel[64];
        Color couleur;
        bool valider=true ; 
        int nb = 65, vide = 0;
        int acquis = 0, ticks=0;
        int [] colores = { 20,20,14,18, 18,14,16,17,11,11,14,11,18,17,16,15,17,18,15,11,15,11,17,13,10,15};
        bool[] resolus = new bool[26];
        public jeux_de_ecriture()
        {
            InitializeComponent();for (int i = 0; i < 26; i++) resolus[i] = false;
        }
        DataRow[] dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =0; i<8; i++) for (int j = 0; j< 8; j++)
                { panels[i * 8 + j] = new Panel();
                    panels[i * 8 + j].Size = new Size(40,40);
                    panels[i * 8 + j].Location = new Point(j * 40, i * 40);
                    panels[i * 8 + j].BackColor = Color.White; panels[i * 8 + j].BorderStyle = BorderStyle.FixedSingle;
                    panel1.Controls.Add(panels[i * 8 + j]);
                    panels[i * 8 + j].Click += B_click;
                    panels[i * 8 + j].Size = new Size(40, 40);
                }
        }
        private void B_click(object sender, EventArgs e)
        {

            Panel pb = (Panel)sender;
            pb.BackColor = couleur;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control c in panel2.Controls) { c.Tag = ""; c.BackColor = Color.Black ; }
            Button btn = (Button)sender;
            btn.Tag = "selected"; btn.BackColor = Color.Gray; couleur = btn.ForeColor;
        }
        private void button6_Click(object sender, EventArgs e)
        {   Bitmap bp=new Bitmap (Application.StartupPath + "\\Pics\\Lettres\\" + ((char)nb).ToString() + "_bip.png");
            int i;
            for ( i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((panels[i * 8 + j].BackColor != bp.GetPixel(j, i)) &&(panels[i * 8 + j].BackColor != Color.White))
                    { valider = false; }
                    if (panels[i * 8 + j].BackColor == Color.White) vide++;
                }
                   
            }
            if (valider == true && vide == 64-colores[nb - 65] && !resolus[nb - 65]) 
            { button6.Text = "Courage!";
                button6.Enabled = false; acquis++; 
                if(!timer1.Enabled) label1.Text = "Acquis: " + acquis + "/26";
                else label1.Text = "Reussi: " + acquis + "/26";
                resolus[nb - 65] = true; }
       else { button7.Visible = true;  }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(new Point(0, 0), new Size(button1.Width, button1.Height)));
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.Blue , new Rectangle(new Point(0, 0), new Size(button1.Width, button1.Height)));
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.Yellow , new Rectangle(new Point(0, 0), new Size(button1.Width, button1.Height)));
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.Green , new Rectangle(new Point(0, 0), new Size(button1.Width, button1.Height)));
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.White , new Rectangle(new Point(0, 0), new Size(button1.Width, button1.Height)));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            suivant_Click();if(timer1.Enabled)timer1.Start();
      
        }

        private void suivant_Click()
        {
            valider = true; button6.Visible = true; button7.Visible = false;
            nb++; vide = 0; if (nb == 91) nb = 65;
            foreach (Control c in panel1.Controls) c.BackColor = Color.White;
            Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\Lettres\\" + ((char)nb).ToString() + "_letter.png");
            pictureBox1.Image = bitmap; button6.Text = "Confirmer"; button6.Enabled = true;

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            valider = true; button7.Visible = false; button6.Visible = true; vide = 0;
            nb--; if (nb == 64) nb = 90;
            foreach (Control c in panel1.Controls) c.BackColor = Color.White;
            Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\Lettres\\" + ((char)nb).ToString() + "_letter.png");
            pictureBox1.Image = bitmap; button6.Text = "Confirmer"; button6.Enabled = true;

        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;timer1.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false; timer1.Enabled = true;timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }
      
        private void picBack_Click(object sender, EventArgs e)
        {
            dr= Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Ecriture"].ToString()) < acquis)
            {

                dr[0]["Ecriture"] = acquis; Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            } 
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 130) {suivant_Click();ticks = 0;
        }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valider = true;vide = 0;
            button6.Visible = true;
            foreach (Control c in panel1.Controls) c.BackColor = Color.White; button7.Visible = false;
        }
    }
}
