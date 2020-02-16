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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int[] dizi = new int[25];
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Numbers have already been created.");
            }
            else
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = rnd.Next(-10, 100);
                }

                for (int i = 0; i < dizi.Length; i++)
                {
                    listBox1.Items.Add(dizi[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dizi.Length, i, j, val, flag;

            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("The numbers are already sorted.");
                }
                else
                {
                    for (i = 1; i < n; i++)
                    {
                        val = dizi[i];
                        flag = 0;
                        for (j = i - 1; j >= 0 && flag != 1;)
                        {
                            if (val < dizi[j])
                            {
                                dizi[j + 1] = dizi[j];
                                j--;
                                dizi[j + 1] = val;
                            }
                            else flag = 1;
                        }
                    }
                    for (int k = 0; k < dizi.Length; k++)
                    {
                        listBox2.Items.Add(dizi[k]);
                    }
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
