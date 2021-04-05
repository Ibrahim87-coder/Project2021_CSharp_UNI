using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.Collections;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Start 
{
    public partial class Apprentissage_1_recone_De_1_sons : Form
    {
       WMPLib.WindowsMediaPlayer p1 = new WMPLib.WindowsMediaPlayer();
        int c = 0, w, z, k;
        string[] s,s1;
        public Apprentissage_1_recone_De_1_sons()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//retourne
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }
        private void button2_Click(object sender, EventArgs e)//recouter
        {
            p1.controls.play();
        }
        DataRow[] dr;
        private void Exercice1ReconaissanceDeSons_Load(object sender, EventArgs e)//load
        {
            c = 0; z = 0; k = 0;
            label4.Hide();
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            w= int.Parse(dr[0]["Prononciation"].ToString());

            if (w != 0) { label7.Visible = true; label6.Visible = true; label6.Text = w + " / 10"; }
            else { label7.Visible = false; label6.Visible = false; }
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true;
            pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            button2.Visible = true;ou.Visible = button1.Visible = false;
            label8.Visible = false; label11.Visible = false; button3.Visible = false;
          s = RandomPhotoExercice1ConnaissanceDeSons();
            s1 = RandomPhotoLettresConnaissance(c);
            pictureBox1.ImageLocation = s[k + 1]; 
          p1.URL = s[k];
            pictureBox2.ImageLocation = s1[0]; pictureBox3.ImageLocation = s1[1];
            pictureBox4.ImageLocation = s1[2]; pictureBox5.ImageLocation = s1[3]; pictureBox6.ImageLocation = s1[4];
        }
      static   Random r = new Random();static int [] aConv = { 1, 2, 3, 6, 7, 10, 11, 14, 19, 9, 15, 17, 21, 25, 22, 23, 31, 39, 27, 45, 40, 48, 64, 65, 54, 75, 70, 77 };

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.ShowInTaskbar = false;
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();int p = 0;
        SpeechRecognitionEngine reconizer = new SpeechRecognitionEngine();
        private void reconizer_reconized(object sender, SpeechRecognizedEventArgs e)
        {
            label9.Visible = false;
            if (label3.Text.ToUpper() == e.Result.Text.ToUpper()) { p++; label5.Text = "Score:  " + p * 10; label3.Text = choices[r.Next(10)].ToUpper(); }
            else label9.Visible = true;
        }
        
            string[] choices = { "a", "b", "g", "k", "o", "q", "u", "c", "f", "i", "l", "m", "n", "p", "r", "s", "v", "x", "y", "z" };

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Visible = false;
            ou.Dispose(); label11.Visible = false;sSynth.SelectVoice(sSynth.GetInstalledVoices()[0].VoiceInfo.Name);
            label7.Visible = false; label6.Visible = false;
            label8.Visible = false; button3.Visible = false; button1.Visible = false;
            pictureBox1.Visible = false; pictureBox2.Visible = false; pictureBox3.Visible = false;
            pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false; label5.Visible = true;
            button2.Visible = false; label3.Visible = label4.Visible = true; reconizer.SetInputToDefaultAudioDevice();
            GrammarBuilder gb = new GrammarBuilder(new Choices(choices));

            reconizer.LoadGrammar(new Grammar(gb));
            reconizer.RecognizeAsync(RecognizeMode.Multiple);
            reconizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconizer_reconized);

        }

        public static string[] RandomPhotoExercice1ConnaissanceDeSons()
        {
            string[] s = new string[21];
            int a, debut = 0, final = 0, c = 0;
            for (int k = 0; k < 20; k = k + 2)
            {
                if (c <= 4) { debut = 1; final = 11; }
                if ((c <= 6) && (c > 4)) { debut = 11; final = 18; }
                if ((c > 6) && (c <= 7)) { debut = 18; final = 21; }
                if ((c ==8) ) { debut = 21; final = 22; }
                if ((c== 9)) { debut = 22; final = 24; }
                if (c ==10) { debut = 24; final = 26; }
                a = r.Next(debut, final);
                if(!aConv.Contains(a)) 
                { k-=2; continue ; }
                for (int j = 0; j < k; j++)
                {
                    if (s[j] == @"Pics\ ExPro" + a + ".png") { a = r.Next(debut, final); j = -1; }
                }
                s[k + 1] = @"Pics\ExPro\" + a + ".png";
                s[k] = @"Voix\ExPro\" + a + ".m4a"; c++;
              
            }
            return s;
        }
        private void pictureBox2_Click(object sender, EventArgs e)//reponse
        {
            PictureBox p = (PictureBox)sender;
            int q = p.ImageLocation.LastIndexOf("\\"), q1 = s[k + 1].LastIndexOf("\\");
            string t = p.ImageLocation.Remove(0, q + 2), t1 = s[k + 1].Remove(0, q1 + 1);
            q = t.LastIndexOf("."); q1 = t1.LastIndexOf(".");
            t = t.Remove(q , 4); t1 = t1.Remove(q1, 4);
            t1 =PhotoLettresConnaissance(t1);
            if (t == t1)
            {
                label9.Visible = false;
                c++; k = k + 2;
                if (c >= 10)
                {
                    w = c+z;
                    dr[0]["Prononciation"]=w; 
                    Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                    pictureBox1.Visible = false; pictureBox2.Visible = false; pictureBox3.Visible = false;
                    pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;label2.Visible = false;
                    button2.Visible = false; button1.Visible = ou.Visible = true;
                    label8.Visible = true; label11.Visible = true; button3.Visible = true; label8.Text = w + " / 10";
                }
                else
                {
                    s1 = RandomPhotoLettresConnaissance(c);
                    pictureBox1.ImageLocation = s[k + 1];
                    p1.URL = s[k];
                    pictureBox2.ImageLocation = s1[0]; pictureBox3.ImageLocation = s1[1];
                    pictureBox4.ImageLocation = s1[2]; pictureBox5.ImageLocation = s1[3]; pictureBox6.ImageLocation = s1[4];
                    int c1 = 0;for (int i = 0; i < s1.Length; i++) if (s1[i] == null) c1++;
                    if (c1 == 1) { pictureBox6.Visible = false; }
                    else if (c1 == 2) { pictureBox6.Visible = false; pictureBox5.Visible = false; }
                    else { pictureBox5.Visible = true; pictureBox6.Visible = true; }
                }
            }
            else { label9.Visible = true; z--; }
            }

        public static string PhotoLettresConnaissance(string t1)
        {
            if (int.Parse(t1) <= 2) { t1 = "1"; }
            if ((int.Parse(t1) ==3)) { t1 = "2"; }
            if ((int.Parse(t1) > 3) && (int.Parse(t1) <= 7)) { t1 = "3"; }
            if ((int.Parse(t1) ==8)) { t1 = "4"; }
            if ((int.Parse(t1) >= 9) && (int.Parse(t1) <= 10)) { t1 = "5"; }
            if ((int.Parse(t1) >=11)&& (int.Parse(t1) <= 15)) { t1 = "6"; }
            if ((int.Parse(t1) ==16)) { t1 = "7"; }
            if ((int.Parse(t1)==17) ) { t1 = "10"; }
            if ((int.Parse(t1) ==18) ) { t1 = "11"; }
            if ((int.Parse(t1) ==19) ) { t1 = "12"; }
            if ((int.Parse(t1) ==20)) { t1 = "13"; }
            if ((int.Parse(t1) ==21) && (int.Parse(t1) <= 52)) { t1 = "15"; }
            if ((int.Parse(t1)==22) && (int.Parse(t1) <= 55)) { t1 = "18"; }
            if ((int.Parse(t1)==23) && (int.Parse(t1) <= 58)) { t1 = "19"; }
            if ((int.Parse(t1)==24) && (int.Parse(t1) <= 61)) { t1 = "20"; }
            if ((int.Parse(t1) >=25) && (int.Parse(t1) <= 26)) { t1 = "22"; }
            return t1;
        }
        public static string[] RandomPhotoLettresConnaissance(int c)
            {
                string[] s1 = new string[5];
                int l = 0;
                if (c <= 4) l = 1;
                if ((c <= 6) && (c > 4)) l = 2;
                if ((c > 6) && (c <= 7)) l = 3;
                if ((c ==8) ) l = 4;
                if (c ==10 || c==9) l = 5;
                if (l == 1) { for (int k = 0; k < 5; k++) s1[k] = @"Pics\ExPro\" + 0 + (k + 1) + ".png"; }
                if (l == 2) { for (int k = 0; k < 5; k++) s1[k] = @"Pics\ExPro\" + 0 + (k + 6) + ".png"; }
                if (l == 3) { for (int k = 0; k < 4; k++) s1[k] = @"Pics\ExPro\" + 0 + (k + 11) + ".png"; }
                if (l == 4) { for (int k = 0; k < 3; k++) s1[k] = @"Pics\ExPro\" + 0 + (k + 15) + ".png"; }
                if (l == 5) { for (int k = 0; k < 5; k++) s1[k] = @"Pics\ExPro\" + 0 + (k + 18) + ".png"; }
                return s1;
            }
        
    }
}
