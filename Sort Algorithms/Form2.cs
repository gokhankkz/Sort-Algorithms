using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] num = new int[25];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Numbers have already been created.");
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = rnd.Next(-10, 100);
                }

                for (int i = 0; i < num.Length; i++)
                {
                    listBox1.Items.Add(num[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("The numbers are already sorted.");
                }
                else
                {
                    for (int i = 0; i < num.Length - 1; i++)
                    {
                        for (int j = i + 1; j < num.Length; j++)
                        {
                            if (num[(j)] < num[(i)])
                            {
                                int temp = num[(j)];
                                num[(j)] = num[(i)];
                                num[(i)] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < num.Length; i++)
                        listBox2.Items.Add(num[i]);
                }
            }
            else
            {
                MessageBox.Show("Please create the numbers first.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
