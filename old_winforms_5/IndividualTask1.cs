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
    public partial class IndividualTask1 : Form
    {
        public IndividualTask1()
        {
            InitializeComponent();
        }

        int[] mas;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            textBox2.Clear();

            int n = Convert.ToInt32(textBox1.Text);

            mas = new int[n];

            for (int i = 0; i + 1 <= n; i++)
            {
                mas[i] = random.Next(-100, 100);
                textBox2.Text += mas[i] + " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minValue = 101;
            int minIndex = -1;

            textBox4.Clear();
            textBox5.Clear();

            for (int i = 0; i + 1 <= mas.Length; i++)
            {
                if (Math.Abs(mas[i]) < minValue)
                {
                    minValue = mas[i];
                    minIndex = i;
                }
            }

            textBox4.Text = Convert.ToString(minIndex + 1);
            textBox5.Text = Convert.ToString(minValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
