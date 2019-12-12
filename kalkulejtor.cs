using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Result_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text += b.Text;
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
       
            Result.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Result.Text = "0";

        }

        private void operator_click(object sender, EventArgs e)
        {
            String dane = Result.Text;
            double x = Convert.ToInt32(dane);


            Console.WriteLine(x + x);
            double wynik = x + x;


            switch (x)
            {
                case 1:

                    Console.WriteLine(wynik);

                    break;



                case 2:


                    break;
            }
        }
        }

       
    }
}
