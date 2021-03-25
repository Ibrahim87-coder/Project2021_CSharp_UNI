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
    public partial class cours_de_Conjugaison : Form
    {
        public cours_de_Conjugaison()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
            Variables.matiere.Show();
            this.ShowInTaskbar = false;
        }

        private void coursConj2_Load(object sender, EventArgs e)
        {

            axAcroPDF1.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\conjugaison.pdf");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
