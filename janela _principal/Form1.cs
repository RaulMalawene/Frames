namespace janela__principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valorA = double.Parse(a.Text);
            double valorB = double.Parse(b.Text);
            double resultado = -valorB / valorA;


            r.Text = resultado.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            r.Text = "";
            a.Text = "";
            b.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            r.Text = "";
            a.Text = "";
            b.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
