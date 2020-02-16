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
    public partial class Form4 : Form
    {
        public Form4()
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
        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(int[] arr, int p, int r)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("The numbers are already sorted.");
                }
                else
                {
                    if (p < r)
                    {
                        int q = (p + r) / 2;
                        mergeSort(arr, p, q);
                        mergeSort(arr, q + 1, r);
                        merge(arr, p, q, r);
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
            mergeSort(num, 0, num.Length - 1);
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Items.Count > 0)
                {

                }
                else
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        listBox2.Items.Add(num[j]);
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
