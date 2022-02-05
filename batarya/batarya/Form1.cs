namespace batarya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float t = float.Parse(textBox1.Text);
            float aov = float.Parse(textBox2.Text);
            float av = float.Parse(textBox3.Text);
            float deg = (float)(1 / (Math.Log(aov / av)));
            double deg2 = 1.442695*t*deg;

            textBox4.Text = deg.ToString();
            textBox5.Text = deg2.ToString();

        }


    }
}