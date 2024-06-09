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
    public partial class GeneralTask2 : Form
    {
        public GeneralTask2()
        {
            InitializeComponent();
        }

        int[] mas;

        private void ShowMas(int [] mas, TextBox textBox)
        {
            foreach (var item in mas)
            {
                textBox.Text += item + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int n = Convert.ToInt32(textBox1.Text);

            mas = new int[n];

            textBox2.Clear();

            for (int i = 0; i + 1 <= n; i++)
            {
                mas[i] = random.Next(0, 100);
                textBox2.Text += mas[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(mas);

            textBox3.Clear();

            ShowMas(mas, textBox3);

            Array.Reverse(mas);

            textBox4.Clear();
            
            ShowMas(mas, textBox4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
