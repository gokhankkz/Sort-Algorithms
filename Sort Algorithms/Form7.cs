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
    public partial class Form7 : Form
    {
        public Form7()
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
        void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BubbleSort(dizi);
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("The numbers are already sorted.");
                }
                else
                {
                    for (int j = 0; j < dizi.Length; j++)
                    {
                        listBox2.Items.Add(dizi[j]);
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
