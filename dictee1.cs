using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Start
{
    public partial class dictee1 : UserControl
    {
        string text1, text2, text3, text4, text5; AxWMPLib.AxWindowsMediaPlayer vn = new AxWMPLib.AxWindowsMediaPlayer();
        //   WMPLib.WindowsMediaPlayer wn = new WMPLib.WindowsMediaPlayer();
        bool[] first = { true, true, true, true, true, true,true  };
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            vn.Ctlcontrols.pause();p.SendToBack();
        }
        public void newEx()
        { textBox1.Text = textBox4.Text = textBox3.Text = textBox2.Text = textBox5.Text = ""; }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 5; i++) { if (i != 2) first[i] = true ; } 
            pictureBox9.SendToBack(); pictureBox8.SendToBack(); pictureBox7.SendToBack(); pictureBox11.SendToBack();
            if (first[2]) { vn.URL = @"Voix/Dic" + (Dictée.t[2] + 1).ToString() + ".m4a"; first[2] = false; }
            vn.Ctlcontrols.play(); pictureBox6.SendToBack();
        }
        jeux_de_heure d;
        private void dictee1_Load(object sender, EventArgs e)
        {
           // label3.Text = DateTime.Now.Date.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 5; i++) { if (i != 1) first[i] = true ; }
            pictureBox10.SendToBack(); pictureBox8.SendToBack(); pictureBox7.SendToBack(); pictureBox11.SendToBack();
            if (first[1]) {vn.URL = @"Voix/Dic" + (Dictée.t[1] + 1).ToString() + ".m4a"; first[1] = false;
        }
        vn.Ctlcontrols.play(); pictureBox2.SendToBack();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) { if (i != 4) first[i] = true; }
            pictureBox10.SendToBack(); pictureBox8.SendToBack(); pictureBox7.SendToBack(); pictureBox9.SendToBack();
            if (first[4]) {vn.URL = @"Voix/Dicc" + (Dictée.t[1] + 1).ToString() + ".m4a"; first[4] = false;
        }
        vn.Ctlcontrols.play(); pictureBox5.SendToBack();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) { if (i != 3) first[i] = true; }
            pictureBox10.SendToBack(); pictureBox9.SendToBack(); pictureBox7.SendToBack(); pictureBox11.SendToBack();
            if (first[3]) { vn.URL = @"Voix/Dicc" + (Dictée.t[3] + 1).ToString() + ".m4a"; first[3] = false;
        }
        vn.Ctlcontrols.play(); pictureBox4.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) { if (i != 0) first[i] = true; }
            pictureBox10.SendToBack(); pictureBox9.SendToBack(); pictureBox8.SendToBack(); pictureBox11.SendToBack();
            if (first[0]) {vn.URL = @"Voix/Dic" + (Dictée.t[0] + 1).ToString() + ".m4a"; first[0] = false; } vn.Ctlcontrols.play(); pictureBox3.SendToBack();


        }

        string[] txt;


        public void texts()
        {
            text1 = textBox1.Text.TrimEnd(' '); text2 = textBox2.Text.TrimEnd(' '); text3 = textBox3.Text.TrimEnd(' ');
            text4 = textBox4.Text.TrimEnd(' '); text5 = textBox5.Text.TrimEnd(' ');

        }
        public string[] Texte
        {
            get { txt = new string[5]; txt[0] = text1; txt[1] = text2; txt[2] = text3; txt[3] = text4; txt[4] = text5; return txt; }
            
        }

        public dictee1()
        {
            InitializeComponent();vn.CreateControl();
           
        }
    }
}
