using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            car myCar2 = new car();
            myCar2.color = "Blue";
            myCar2.speed = 250;
            myCar2.engine = 1.5;
            myCar2.status = '2';
            myCar2.price = 25000;

            label1.Text = "Color: " + myCar2.color;
            label2.Text = "Speed: " + myCar2.speed;
            label3.Text = "Engine: " + myCar2.engine;
            label4.Text = "Status: " + myCar2.status;
            label5.Text = "Price: " + myCar2.price;
        }
    }
}
