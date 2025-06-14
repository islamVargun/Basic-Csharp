namespace extra_structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int sayi1 = rnd.Next(0,100);
            //int sayi2 = rnd.Next(0,100);
            //int sayi3 = rnd.Next(0,100);
            //label1.Text = sayi1.ToString();
            //label2.Text = sayi2.ToString();
            //label3.Text = sayi3.ToString();

            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(1,5);
            s2 = random.Next(1,5);
            s3 = random.Next(1,5);
            s4 = random.Next(1,5);
            label1.Text=s1.ToString();
            label2.Text=s2.ToString();
            label3.Text=s3.ToString();
            label4.Text=s4.ToString();

            //sayi1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else 
            { 
            textBox1 .BackColor = Color.Red;
            }


            //sayi2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }


            //sayi3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }


            //sayi4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
