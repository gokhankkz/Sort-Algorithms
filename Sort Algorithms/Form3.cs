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
    public partial class Form3 : Form
    {
        public Form3()
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
        public int partition(int[] A, int first, int second)
        {
            int temp;
            int x = A[second];
            int i = first - 1;
            for (int j = first; j <= second - 1; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            temp = A[i + 1];
            A[i + 1] = A[second];
            A[second] = temp;
            return i + 1;
        }
        public void QuickSort(int[] dizi, int first, int second)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("The numbers are already sorted.");
                }
                else
                {
                    int i;
                    if (first < second)
                    {
                        i = partition(dizi, first, second);
                        QuickSort(dizi, first, i - 1);
                        QuickSort(dizi, i + 1, second);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please create the numbers first.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuickSort(dizi, 0, dizi.Length - 1);
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {

                }
                else
                {
                    for (int j = 0; j < dizi.Length; j++)
                    {
                        listBox2.Items.Add(dizi[j]);
                    }
                }
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
