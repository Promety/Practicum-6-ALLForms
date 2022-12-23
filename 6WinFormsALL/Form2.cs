using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//5.	Подсчитать среднее арифметическое элементов
namespace _6WinFormsALL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = int.Parse(numericUpDown1.Text);
            int m = int.Parse(numericUpDown2.Text);
              
            int[,] arr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
            {
                arr[i,j] = rand.Next(-100, 100);
                textBox1.Text += ($"a[{i},{j}]={ arr[i,j] }")+Environment.NewLine;
            }
            int sum = 0;
            float middle = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];

                    middle = sum / (m * n);

                   // textBox1.Text += (arr[i, j] + "\t");
                }
                

            }
            textBox1.Text += "среднеарифметическое =" + middle;
        }
    }
}
