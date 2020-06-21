using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract7_ex2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string[] words = str.Split(' ');
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 1)
                    textBox2.AppendText(words[i] + " ");
            }
            
        }
    }
}
