using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] myArray = new string[2];  
            //myArray[0] = "Stej";
            //myArray[1] = "Steph";
            //MessageBox.Show(myArray[1]);


            // Iteratiojn statements
            //string[] myArray = { "Ste", "SteJ", "Stevo", "Steph" };
            //foreach (var nickname in myArray)
            //{
            //MessageBox.Show(nickname);
            //}

            // For 
            //string[] myArray = { "Ste", "SteJ", "Stevo", "Steph" };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //MessageBox.Show(i.ToString());

        }

            //While loop
            private void textBox1_TextChanged(object sender, EventArgs e)
           {
            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            // i++;
            // }
            //MessageBox.Show("The final value was: " + i.ToString());
         

            // 2 nested for loop

            //string[] myArray = { "Ste", "SteJ", "Stevo", "Steph" };
            //for (int i = 0; i < myArray.Length; )
            //{
                //foreach (var nickname in myArray)
                //{
                    //MessageBox.Show(i++ + "" + nickname);
                ///}
            //}

            string[] myArray = { "Ste", "SteJ", "Stevo", "Steph" };
            for (int i = 0; i < myArray.Length; )
            {
                switch myArray
                {
                    case "Ste":
                        MessageBox.Show(i.value);

                    case "SteJ":
                        MessageBox.Show(i.value);

                    case "Stevo":
                        MessageBox.Show(i.value);
                    case "Steph":
                        MessageBox.Show(i.value);
                        break;
                }
            }
        }
    }
}    

