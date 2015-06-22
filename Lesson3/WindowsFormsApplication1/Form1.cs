using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hello; //Hello is the bucket
            //hello = "Hello World";  // string literal goes into the hello bucket
            //MessageBox.Show(hello);
            //MessageBox.Show("hello");

            //string firstTextBox = textBox1.Text;
            //string secondTextBox = textBox2.Text;

            //label3.Text = firstTextBox + " " + secondTextBox;

            //int myValue = 3;  // data type integer
            //double myOtherValue;  // data type double
            //myOtherValue = myValue;  // VS converts from int to double

            int firstTextBox = 0;
            int secondTextBox = 0;
            int result = 0;

            firstTextBox = int.Parse(textBox1.Text);
            secondTextBox = int.Parse(textBox2.Text);

            result = firstTextBox + secondTextBox;
            label3.Text = result.ToString();
        }
    }
}
