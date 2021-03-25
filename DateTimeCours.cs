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
    public partial class cours_de_heure : Form
    {
        public cours_de_heure()
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
            Application.Exit();
        }

        private void DateTimeCours_Load(object sender, EventArgs e)
        {

            axAcroPDF4.Visible = true;
            axAcroPDF4.Height = 400;
            axAcroPDF4.Width = 750;
            axAcroPDF4.Location = new Point(160, 120);
            axAcroPDF4.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\Date.pdf");
        }
    }
}
