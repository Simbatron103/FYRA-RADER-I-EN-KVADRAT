using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYRA_RADER_I_EN_KVADRAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sum = 0;
        int smallman = 0;
        int number = 1;
        int bigman = 2;
        private void button1_Click(object sender, EventArgs e)
        {

           sum = int.Parse(textBox1.Text);
           bigman = int.Parse(textBox2.Text);
            while (sum < bigman)
            {
                sum = sum + number;

                textBox3.Text = textBox3.Text + sum * sum + " ";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bigman = int.Parse(textBox2.Text);
            sum = int.Parse(textBox1.Text);
            for (sum = int.Parse(textBox1.Text); sum  <= bigman + 1; sum++)
            {
                smallman = sum * sum;
                textBox3.Text = textBox3.Text + smallman + " ";
            }
        }
    }
}
