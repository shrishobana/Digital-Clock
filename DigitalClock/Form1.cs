using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            
            string Time = "";
            if (hh < 10)
            {
                Time += "0" + hh;
            }
            else
            {
                Time += hh;
            }
            Time += ":";
            if (mm < 10)
            {
                Time += "0" + mm;
            }
            else
            {

                Time += mm;
            }
            Time += ":";
            if (ss < 10)
            {
                Time += "0" + ss;
            }
            else
            {
                Time += ss;
            }
            Time += ":";
            label1.Text = Time;
        }
    }
}
