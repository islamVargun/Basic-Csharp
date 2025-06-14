using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example
{
    internal class car:carinfo
    {


        public string color;
        public int speed;
        public double engine;
        public char status;
        public int price;
        private int year;
        private string trademark;

        public int YIL
        {
            get { return year; }
            set { year = Math.Abs(value); }
        }
        public string tradeMark
        {
            get { return trademark; }
            set { trademark = value.ToUpper(); }
        }
    }
}