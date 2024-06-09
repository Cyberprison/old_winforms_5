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
    public partial class IndividualTask2 : Form
    {
        public IndividualTask2()
        {
            InitializeComponent();
        }

        int[] mas;

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            textBox2.Clear();
            textBox3.Clear();

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
            int[] mas2 = new int[mas.Length];

            Array.Copy(mas, 0, mas2, 0, mas.Length);

            Array.Copy(mas, 0, mas2, mas2.Length - 3, 3);

            Array.Copy(mas, mas.Length - 3, mas2, 0, 3);

            for (int i = 0; i + 1 <= mas.Length; i++)
            {
                textBox3.Text += mas2[i] + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
