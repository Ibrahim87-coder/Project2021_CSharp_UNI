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
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }
        string operation = null;
        string opearande1 = null;


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            t.Text += b.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (t.Text.Length > 0)
            {
                t.Text += "0";
            }
        }

        private string Effectuer ( string Operation , string Operande1, string Operande2)
        {
            if (Operation == "+")
                return (double.Parse(Operande1) + double.Parse(Operande2)).ToString();
            else if (Operation == "-")
                return (double.Parse(Operande1) - double.Parse(Operande2)).ToString();
            else if (Operation == "*")
                return (double.Parse(Operande1) * double.Parse(Operande2)).ToString();
            else if (Operation == "/")
                return (double.Parse(Operande1) / double.Parse(Operande2)).ToString();
            else return "";


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (t.Text.IndexOf(".") < 0)
            {
                t.Text += ".";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((operation != null) && (t.Text.Length > 0))
            {
             
                t.Text = Effectuer(operation, opearande1, t.Text);
                opearande1 = null;
                operation = null;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ( t.Text.Length > 0)
            {
                Button b = (Button)sender;

                if (operation == null)
                {
                    opearande1 = t.Text;
                   
                }
                else
                {
                    opearande1 = Effectuer(operation, opearande1, t.Text);

                }
                operation = b.Text;

                t.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t.Text = "";
            operation = null;
            opearande1 = null;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (t.Text.Length > 0)
            {
                t.Text = t.Text.Remove(t.Text.Length - 1);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
