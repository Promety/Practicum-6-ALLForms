using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//5.    Вывести на экран номера всех элементов, не совпадающих с максимальным. 
namespace _6WinFormsALL
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double max = 0;
            int n = int.Parse(numericUpDown1.Text);
            double[] G = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                G[i] = rand.Next(-100, 100);
                textBox1.Text += $"{G[i]} ";
            
          
                {
                    if (G[i] > max) max = G[i];

                }
            }

            textBox1.Text +=$"Максимальное число: {max}\n";
            textBox1.Text += "Список элементов не совпадающих с максимальным:\n";
            for (int j = 0; j < G.Length; j++)
            {
                
                if (G[j] != max) textBox1.Text+=(j + " ");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
