using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//5.	Поменять местами столбцы по правилу: первый с последним, второй с предпоследним и т.д. 
namespace _6WinFormsALL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = int.Parse(numericUpDown1.Text);

            int m = int.Parse(numericUpDown2.Text);

            int[,] a = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    textBox1.Text += ($"a[{i},{j}]={ a[i, j] }") + Environment.NewLine;
                }
            textBox1.Text +=("До: ")+Environment.NewLine;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBox1.Text += (a[i, j] + "\t");

                }
                textBox1.Text += "" + Environment.NewLine;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    int x = a[i, j];
                    a[i, j] = a[i, (m - 1) - j];
                    a[i, (m - 1) - j] = x;
                }
            }
            textBox1.Text += ("После: ") + Environment.NewLine;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    textBox1.Text +=(a[i, j] + "\t");
                textBox1.Text += "" + Environment.NewLine;
            }
        }
    }
}
