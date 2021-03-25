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
    public partial class cours_de_decroi_croi : Form
    {
        public cours_de_decroi_croi()
        {
            InitializeComponent();
        }

      
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;

        }

        private void ComparaisonCours_Load(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = true;
            axAcroPDF1.Height = 400;
            axAcroPDF1.Width = 750;
            axAcroPDF1.Location = new Point(160, 120);
            axAcroPDF1.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\CroissEtDecroi.pdf");
        }
    }
}
