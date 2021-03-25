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
    public partial class cours_de_fraction : Form
    {
        public cours_de_fraction()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        private void fractionCours_Load(object sender, EventArgs e)
        {
            axAcroPDF2.Visible = true;
            axAcroPDF2.Height = 400;
            axAcroPDF2.Width = 750;
            axAcroPDF2.Location = new Point(160, 120);
            axAcroPDF2.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\Fraction.pdf");
        }
    }
}
