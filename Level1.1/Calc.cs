using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(leftRichTextBox.Text, out int a) && int.TryParse(rightRichTextBox.Text, out int b))
            {
                resultRichTextBox.Text = (a + b).ToString();
            }
        }
    }
}