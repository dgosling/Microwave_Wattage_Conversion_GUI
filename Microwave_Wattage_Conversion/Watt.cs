using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_Wattage_Conversion
{

    class Watt
    {
        private
            double wattage1=0;
            double wattage2=0;
            double time1=0;
            double time2=0;

        public double get_wattage1()
        {
            return wattage1;
        }
        public double get_wattage2()
        {
            return wattage2;
        }
        public double get_time1()
        {
            return time1;
        }
        public string get_time2()
        {
            int a = (int)Math.Round(time2);
            return a.ToString();
        }

        public void set_wattage1(double a)
        {
            wattage1 = a;
            Console.WriteLine("set wattage1 to " + a);
        }
        public void set_wattage2(double a)
        {
            wattage2 = a;
            Console.WriteLine("set wattage2 to " + a);
        }
        public void set_time1(double a)
        {
            time1 = a;
            Console.WriteLine("set time1 to " + a);
        }
        public void set_time2()
        {
            time2 = (wattage1 / wattage2) * time1;
            Console.WriteLine("set time2 as" + time2);
        }


    }
}
