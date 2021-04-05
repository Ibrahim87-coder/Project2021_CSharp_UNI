using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Start
{
    public partial class cours_de_ecriture : Form
    {
        public cours_de_ecriture()
        {
            InitializeComponent();
        }
        int i = 0;
        //XmlDocument ecritureTbl; 
        string[] RepLettres=
        {
            "1111111111111444111111411141111141114111114111411111444441111141114111114111411111411141111111111111",
            "1111111111111111111111222211111121112111112111211111222211111121112111112111211111222211111111111111",
            "1111111111111555111111511151111151111111115111111111511111111151111111115111511111155511111111111111",
            "1111111111113333111111311131111131113111113111311111311131111131113111113333111111111111111111111111",
            "1111111111114444411111411111111141111111114444111111411111111141111111114444411111111111111111111111",
            "1111111111112222211111211111111121111111112222111111211111111121111111112111111111111111111111111111",
            "1111111111111155511111151115111115111111111511111111151111111115115511111511151111115551111111111111",
            "1111111111111111111111131113111113111311111311131111133333111113111311111311131111131113111111111111",
            "1111111111111111111111144411111111411111111141111111114111111111411111111141111111144411111111111111",
            "1111111111111111111111112221111111121111111112111111111211111111121111112112111111122111111111111111",
            "1111111111111111111111151115111115115111111515111111155111111115151111111511511111151115111111111111",
            "1111111111111311111111131111111113111111111311111111131111111113111111111333331111111111111111111111",
            "1111111111111111111111411141111144144111114141411111414141111141114111114111411111411141111111111111",
            "1111111111111111111111211121111121112111112211211111212121111121122111112111211111211121111111111111",
            "1111111111111111111111155511111151115111115111511111511151111151115111115111511111155511111111111111",
            "1111111111111111111111333311111131113111113111311111333311111131111111113111111111311111111111111111",
            "1111111111111111111111144411111141114111114111411141411141111141414111114114111111144141111111111111",
            "1111111111111111111111333311111131113111113111311111333311111131311111113113111111311131111111111111",
            "1111111111111111111111155551111151111111115111111111155511111111115111111111511111555511111111111111",
            "1111111111111111111111333331111111311111111131111111113111111111311111111131111111113111111111111111",
            "1111111111111111111111411141111141114111114111411111411141111141114111114111411111144411111111111111",
            "1111111111111111111111121112111112111211111211121111112121111111212111111112111111111111111111111111",
            "1111111111111111111111511151111151115111115111511111515151111151515111115151511111151511111111111111",
            "1111111111111111111111131113111113111311111131311111111311111111313111111311131111131113111111111111",
            "1111111111111111111111141114111114111411111141411111111411111111141111111114111111111411111111111111",
            "1111111111111111111111222221111111112111111112111111112111111112111111112111111111222221111111111111",
        };
        bool coloring = false  ;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        Graphics g;
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
          
            // p.Hide();p.Size = new Size(30, 30);
            for (int j = 0; j < 10; j++)
                for (int k = 0; k < 10; k++)
                {      
                 
                        if (coloring && RepLettres[i][k + j * 10] != '1' && e.Row == j && e.Column == k )
                    {    
                       g.FillRectangle(Brushes.WhiteSmoke   , e.CellBounds);  
                       
                   Thread.Sleep(500);
                }
                }
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             i--;coloring = false; if (i == 0) pictureBox1.Visible = false;else { pictureBox1.Visible = true;pictureBox2.Visible = true ; }
            label1.Text = "La lettre" + (char)(i + 65); 
       /*this.Invoke(new MethodInvoker =>Form1_Load)*/
        }
       
        private void EcrCours_Load(object sender, EventArgs e)
        {
            g = TableLayoutPanel1.CreateGraphics();
            //ecritureTbl = new XmlDocument();
            //ecritureTbl.Load(Application.StartupPath + @"\Ecriturre.xml");//RepLettres = ecritureTbl.GetElementsByTagName("Ecriture")[0].InnerText.Split(','); MessageBox.Show(ecritureTbl.GetElementsByTagName("Ecriture")[0].InnerText.Split(',')[6]);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //pictureBox1.Enabled = false; pictureBox2.Enabled = false; this.Refresh(); 
            //if(pictureBox2.Enabled)
         
            i++; coloring = false; g.Clear(Color.WhiteSmoke);
            if (i == 25){pictureBox2.Visible = false; label1.Visible = pictureBox1.Visible = pictureBox3.Visible = pictureBox2.Visible = false; label2.Visible = label4.Visible = button1.Visible = true; }
            else { pictureBox1.Visible = true; pictureBox2.Visible = true; }
             
                label1.Text = "La lettre " + (char)(i + 65);  this.Refresh();
           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            coloring = true; this.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0; label2.Visible = label4.Visible = button1.Visible = false ;label1.Text = "La lettre A"; label1.Visible = true;pictureBox2.Visible = pictureBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar=true;

        }
    }
}
