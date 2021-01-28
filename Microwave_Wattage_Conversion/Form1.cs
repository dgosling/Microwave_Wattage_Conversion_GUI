using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_Wattage_Conversion
{
    
    public partial class Form1 : Form
    {
        Watt watt = new Watt();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void watt1In_TextChanged(object sender, EventArgs e)
        {
            
            watt.set_wattage1(double.Parse(watt1In.Text));
            
        }

        private void time1In_TextChanged(object sender, EventArgs e)
        {
            watt.set_time1(double.Parse(time1In.Text));
        }

        private void watt2In_TextChanged(object sender, EventArgs e)
        {
            watt.set_wattage2(double.Parse(watt2In.Text));
            watt.set_time2();
            time2Out.Text = watt.get_time2();
        }

    }
}
