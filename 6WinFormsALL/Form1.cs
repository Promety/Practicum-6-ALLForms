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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse(numericUpDown1.Text);
            int[] G = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                G[i] = rand.Next(-100, 100);
                textBox1.Text += $"{G[i]} ";
            }
            int sum = 0;
            double count = 0;
            for (int j = 0; j < n; j++)
            {
                sum += G[j];
                count++;
            }
            textBox1.Text += "\nСреднееарифметическое будет : " + sum / count;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
