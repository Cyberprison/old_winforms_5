using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace old_winforms_5
{
    public partial class GeneralTask1 : Form
    {
        public GeneralTask1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int[] mas;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int n = Convert.ToInt32(textBox1.Text);

            mas = new int[n];

            textBox2.Text = "";

            for (int i = 0; i + 1 <= n; i++)
            {
                mas[i] = random.Next(0, 20);
                textBox2.Text += mas[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minValue = 21;
            int minIndex = 0;

            textBox3.Text = "";

            for (int i = 0; i + 1 <= mas.Length; i++)
            {
                if (mas[i] < minValue)
                {
                    minValue = mas[i];
                    minIndex = i;
                }

                textBox3.Text += Convert.ToString(Math.Pow(mas[i], 2)) + " ";
            }

            textBox4.Text = Convert.ToString(minValue);
            textBox5.Text = Convert.ToString(minIndex + 1);
        }
    }
}
