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
    public partial class intro_video : Form
    {
        public intro_video()
        {
            InitializeComponent();

        }
        int ticks=0;Label l = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            try 
            { 
                progressBar1.Value += 2;
            } 
            catch { }
            
            if(ticks==55)
            {
                timer1.Stop();
                this.Close();
                Variables.intro.Show(); 
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
