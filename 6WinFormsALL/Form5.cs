    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace _6WinFormsALL
    {
        public partial class Form5 : Form
        {
            Random rand = new Random();
            public Form5()
            {
                InitializeComponent();
            }
             int[][] Input()
            {
           
                int n = int.Parse(numericUpDown1.Text);
                int[][] a = new int[n][];
                for (int i = 0; i < n; ++i)
                {
                    a[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        a[i][j] = rand.Next(-50, 50);
                        textBox1.Text += $"a[{i},{j}]=" + a[i][j] + Environment.NewLine;
                    
                    }
                }
                return a;
            }

           void print(int[][] a)
            {
                for (int i = 0; i < a.Length; i++, textBox1.Text+=" ")
                {
                    for (int j = 0; j < a[i].Length; j++)
                    {
                        textBox1.Text += $"{a[i][j]}\t";
                    }
                    textBox1.Text += "" + Environment.NewLine;
                    
                }
                

            }
            void print2(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                    textBox1.Text += $" {a[i]}"+Environment.NewLine;
            }

             int Pol(int[] a)
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (1 <= a[i])
                        count++;
                }
                return count;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                int[][] mass = Input();
                textBox1.Text += ("Исходный массив:" + Environment.NewLine);
                print(mass);
                int[] rez = new int[mass.Length];
                for (int i = 0; i < mass.Length; ++i)
                    rez[i] = Pol(mass[i]);
                textBox1.Text += ("Новый массив" + Environment.NewLine);
                print2(rez);
            }
        }
    }
