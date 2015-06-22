using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "Murph") { 
               // MessageBox.Show("You picked Murph");
             //comboBox1.Text = " ";
            if (comboBox1.Text != "Murph")
            {               
                if (comboBox1.Text == "Timmy")
                {
                    MessageBox.Show("You picked Timmy");
                }
                else 
                {
                    MessageBox.Show("I'm not sure who you picked.");
                }
            }

            else
            {
                MessageBox.Show("You picked Murph");
            }
        }

    }
}
