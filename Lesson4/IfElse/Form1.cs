using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedItem.ToString(){
                case "Foobar":
                    MessageBox.Show("You picked Foobar");
                    break;

                case"Bazquick":
                    MessageBox.Show("You picked Bazquick");
                    break;

                default:
                    MessageBox.Show("You picked something else");
                    break;
            }

          }
    }


        
        
        
        
        
        

            //if (comboBox1.Text == "Murph") { 
               // MessageBox.Show("You picked Murph");
             //comboBox1.Text = " ";
            //if (comboBox1.Text != "Murph")
           // {               
                //if (comboBox1.Text == "Timmy")
                //{
                    //MessageBox.Show("You picked Timmy");
               // }
                //else 
                //{
                   // MessageBox.Show("I'm not sure who you picked.");
                //}
           // }

            //else
            //{
               // MessageBox.Show("You picked Murph");
            //}
        //}

   // }

