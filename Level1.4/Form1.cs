using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level1._4
{
    /// <summary>
    /// Ввести пять различных чисел в RichTextBox1, разделяя
    /// их пробелами. Умножить каждое из этих чисел на 2 и вывести в
    /// RichTextBox2, каждое в новую строку, снабдив результат заголовком.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = richTextBox1.Text.Split(' ').Select(x => int.Parse(x) * 2).ToArray();
            richTextBox2.Text = "Result:\n";
            for (var i = 0; i < arr.Length; i++)
            {
                richTextBox2.Text += $"N{i+1} - {arr[i]}\n";
            }
        }
    }
}