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
    public partial class Form14 : Form
    {
        public Form14()
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
        public static void GnomeSort(ref int[] data)
        {
            for (int i = 1; i < data.Length;)
            {
                if (data[i - 1] <= data[i])
                    ++i;
                else
                {
                    int tmp = data[i];
                    data[i] = data[i - 1];
                    data[i - 1] = tmp;
                    --i;
                    if (i == 0)
                        i = 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GnomeSort(ref dizi);
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
