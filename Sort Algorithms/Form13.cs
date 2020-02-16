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
    public partial class Form13 : Form
    {
        public Form13()
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
        public static void combosort(ref int[] arr)
        {
            double gap = arr.Length;
            bool swap = true;
            while (gap > 1 || swap)
            {
                gap /= 1.247330950103979;
                if (gap < 1)
                    gap = 1;
                int i = 0;
                swap = false;
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    if (arr[i] > arr[igap])
                    {
                        int temp = arr[i];
                        arr[i] = arr[igap];
                        arr[igap] = temp;
                        swap = true;
                    }
                    ++i;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            combosort(ref dizi);
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
