using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string text = "";

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
