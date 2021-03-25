using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Start 
{
    class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
    class XmlFrns
    { XmlDocument gramm;
        public XmlDocument gram
        {
            get
            {
                gramm = new XmlDocument();
                gramm.Load(Application.StartupPath + @"\Francais.xml");return gramm;
            }
        }

}

    class ComMethodes
    {
         public  static  ArrayList Generate(int len,int max)
        {
            Random r = new Random();
            int num; ArrayList randList = new ArrayList();
            do { do { num = r.Next(max ); } while (randList.Contains(num)); randList.Add(num); } while (randList.Count != len);
            return randList;

        }
    }
}
