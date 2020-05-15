using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                int[,] mass = new int[n, n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i, j] = r.Next(1, 100);
                        textBox1.Text += mass[i, j] + "     " + "\n\r";
                    }
                    textBox1.Text += "\n\r";
                }

                for (int i = 0; i < n; i++)
                {
                    int k = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (mass[j, i] < mass[k, i])
                        {
                            k = j;
                        }
                    }
                    mass[k, i] = 0;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        textBox2.Text += mass[i, j] + "     " + "\n\r";
                    }
                    textBox2.Text += "\n\r";
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
