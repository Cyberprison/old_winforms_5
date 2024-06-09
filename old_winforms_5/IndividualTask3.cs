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
    public partial class IndividualTask3 : Form
    {
        public IndividualTask3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] mas = new int[n];
            Random random = new Random();
            textBox2.Clear();

            int countNegativeNumber = 0;

            int maxValue = -11;
            int sumMaxValue = 0;
            int countMaxValue = 0;
            
            int minValue = 11;
            int sumMinValue = 0;
            int countMinValue = 0;

            int countEvenNumber = 0;
            int sumEvenNumber = 0;

            for (int i = 0; i + 1 <= n; i++)
            {
                mas[i] = random.Next(-10, 10);
                textBox2.Text += mas[i] + " ";

                if (mas[i] < 0)
                {
                    countNegativeNumber++;
                }

                if(mas[i] > maxValue)
                {
                    maxValue = mas[i];
                }
                
                if (mas[i] < minValue)
                {
                    minValue = mas[i];
                }

                if (i%2 == 0)
                {
                    countEvenNumber++;
                    sumEvenNumber += mas[i];
                }
            }

            for (int i = 0; i + 1 <= n; i++)
            {
                if(mas[i] == maxValue)
                {
                    sumMaxValue += mas[i];
                    countMaxValue++;
                }
                
                if (mas[i] == minValue)
                {
                    sumMinValue += mas[i];
                    countMinValue++;
                }
            }

            textBox3.Text = Convert.ToString(countNegativeNumber);
            textBox4.Text = Convert.ToString(sumMaxValue);
            textBox5.Text = Convert.ToString(sumMaxValue / countMaxValue);
            textBox6.Text = Convert.ToString(sumMinValue / countMinValue);
            textBox7.Text = Convert.ToString(sumEvenNumber / countEvenNumber);

        }
    }
}
