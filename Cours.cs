using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace  Start 
{
    public partial class Cours : Form
    {
       
        public Cours()
        {
            InitializeComponent();
            labels[3] = label1;labels[0] = label2;labels[1] = label3;labels[2] = label4;
            txt = label2.Text;len = txt.Length;
        }
        Bitmap []  imageConv;int i = 0,j=0, counter = 0, len = 0;string txt; public  bool conjugaison=true   ;public int debut, fin; Label[] labels= new Label[4];//SpeechSynthesizer sSynth;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {if (conjugaison)
            {
                sSynth.Dispose();
                timer1.Stop();
                counter = 0;
                j++;
                l++; 
                pictureBox3.Visible = true; 
                clse.Visible = true; 
                if (j == 4) clse.Visible = false;
           
                if (j <= 3)
                {

                    txt = labels[l].Text;sSynth = new SpeechSynthesizer();
                    sSynth.SelectVoice(sSynth.GetInstalledVoices()[2].VoiceInfo.Name); sSynth.SpeakAsync(txt);
                    len = txt.Length; 
                    panel1.Visible = false; 
                    video.Ctlenabled = false; 
                    pictureBox1.Visible = false;
                    video.Visible = false; 
                    text();
                    labels[l - 1].Visible = false;
                    labels[l].Visible = true;
                    text();
                    video.Visible = false;
                }
                if (j == 4) 
                { 
                    panel1.Visible = true;
                    video.Ctlenabled = true;
                    video.Size = new Size(400, 300);   
                    video.Visible = true;
                    video.BringToFront();
                    video.URL = "\\videos\\videoConj1.mp4"; 
                    label1.Visible = false;
                }
            }
            else 
            {
                i++;
                pictureBox1.Image = imageConv[i]; 
                pictureBox3.Visible = true; 
                pictureBox4 .Visible = true;
                if (i == fin-2) 
                    pictureBox4.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (conjugaison)
            {
                sSynth.Dispose();
              if(l!=4)  labels[l].Text = txt;
                
                j--;
                l--;
                pictureBox3.Visible = true;
                clse.Visible = true;
                if (j == 0 ) pictureBox3.Visible = false;
                if (j <= 3)
                {

                    txt = labels[l].Text;sSynth = new SpeechSynthesizer();
                    sSynth.SelectVoice(sSynth.GetInstalledVoices()[2].VoiceInfo.Name); sSynth.SpeakAsync(txt); len = txt.Length;video.URL = "";panel1.Visible = false; video.Ctlenabled = false; pictureBox1.Visible = false; video.Visible = false; text(); if (l != 3) labels[l+1].Visible = false; labels[l].Visible = true; text(); video.Visible = false;
                   
                }

                if (j==4)
                {  
                    txt = labels[l].Text;
                    len = txt.Length; 
                    panel1.Visible = false;
                    video.Ctlenabled = false; 
                    pictureBox1.Visible = false;
                    video.Visible = false;
                    if(l!=3) labels[l + 1].Visible = false; 
                    labels[l].Visible = true; text();
                    video.Visible = false;
                    video.Ctlenabled = false;
                }
            }
            else
            { 
                i--;
                pictureBox1.Image = imageConv[i];
                pictureBox3.Visible = true;
                pictureBox4 .Visible = true;
                if (i == debut-1) 
                    pictureBox3.Visible = false; 
            }
           
        }
        
       
        

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Variables.g.ShowInTaskbar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.ShowInTaskbar = false;
        }
       SpeechSynthesizer sSynth = new SpeechSynthesizer();
        private void Cours_Load(object sender, EventArgs e)
        {
            timer2.Start();i = debut-1;
            imageConv = new Bitmap[50];
            
            for (int i = 1; i < 49; i++) 
                try 
                { 
                    imageConv[i - 1] = new Bitmap(Application.StartupPath + @"\Cours\" + i + ".jpg");
                } catch
                { 
                    imageConv[i - 1] = new Bitmap(Application.StartupPath + @"\Cours\" + i + ".png");
                }
            try { pictureBox1.Image = imageConv[debut-1]; } catch { }
            if (conjugaison)
            {
                //PromptBuilder pBuilder = new PromptBuilder();CultureInfo.CurrentCulture=new CultureInfo("fr_FR");
                //SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine(new CultureInfo("fr_FR"));

                //pBuilder.ClearContent();

                //pBuilder.AppendText("je mange");
                //sSynth.Speak(pBuilder);
                sSynth.SelectVoice(sSynth.GetInstalledVoices()[2].VoiceInfo.Name );
                sSynth.SpeakAsync(txt);
                pictureBox1.Visible = false; label2.Visible = true; text();
            }
        }
        private void text()
        {
            counter = 0;
            labels[l].Text = "";
            timer1.Start();
        } 
        int l=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++; 
            if (counter > len)
            { timer1.Stop(); }
            else
            {
                labels[l].Text = txt.Substring(0, counter); 
                if (labels[l].ForeColor == Color.Black) labels[l].ForeColor = Color.Indigo;
                else labels[l].ForeColor = Color.Black;
            }
        }
    }
}
