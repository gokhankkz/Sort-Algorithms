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
    public partial class Form8 : Form
    {
        public Form8()
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
                    dizi[i] = rnd.Next(0, 100);
                }

                for (int i = 0; i < dizi.Length; i++)
                {
                    listBox1.Items.Add(dizi[i]);
                }
            }
        }
        public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }
        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];
            for (i = 0; i < 10; i++)
                count[i] = 0;
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
        public static void radixsort(int[] arr, int n)
        {
            int m = getMax(arr, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            radixsort(dizi, dizi.Length);
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
