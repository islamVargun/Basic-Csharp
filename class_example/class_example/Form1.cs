using System.Drawing.Text;

namespace class_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car myCar = new car();

            myCar.color = "Red";
            myCar.speed = 200;
            myCar.engine = 1.7;
            myCar.status = '0';
            myCar.price = 20000;
            myCar.YIL = -2010;
            myCar.tradeMark = "Ford";
            myCar.muayene = 2023;
            myCar.plaka = "34 ABC 36";
            myCar.sahip = "islam vargun";

            label1.Text = "Color: " + myCar.color;
            label2.Text = "Speed: " + myCar.speed.ToString();
            label3.Text = "Engine: " + myCar.engine;
            label4.Text = "Status: " + myCar.status;
            label5.Text = "Price: " + myCar.price;
            label6.Text = "Year: " + myCar.YIL;
            label7.Text = "Trademark: " + myCar.tradeMark;
            pictureBox1.BackColor = Color.CadetBlue;
            label8.Text = "Muayene: " + myCar.muayene;
            label9.Text = "Plaka: " + myCar.plaka;
            label10.Text = "Sahip: " + myCar.sahip;


        }
    }
}
