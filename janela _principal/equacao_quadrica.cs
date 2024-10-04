using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janela__principal
{
    public partial class equacao_quadrica : Form
    {
        public equacao_quadrica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorA = double.Parse(a.Text);
            double valorB = double.Parse(b.Text);
            double valorC = double.Parse(c.Text);

            double valorDel = (valorB * valorB) - 4 * valorA * valorC;

            delta.Text = valorDel.ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void equacao_quadrica_Load(object sender, EventArgs e)
        {

        }
    }
}
