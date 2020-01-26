using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Xwins.Text = "X wygrane: " + s1;
            Owins.Text = "O wygrane:" + s2;
            Draws.Text = "Remisy: " + sd;  
        }
      void NewGame()
        {

            player = 2;
            turns = 0;

            A00.Text = A01.Text = A02.Text=A03.Text=A04.Text = A10.Text = A11.Text = A12.Text =A13.Text=A14.Text= A20.Text = A21.Text = A22.Text =A23.Text=A24.Text= A30.Text = A31.Text = A32.Text = A33.Text = A34.Text= A40.Text = A41.Text = A42.Text = A43.Text = A44.Text= "";


            Xwins.Text = "X wygrane: " + s1;
            Owins.Text = "O wygrane:" + s2;
            Draws.Text = "Remisy: " + sd;

        }

      bool CheckDraw()
        {

            if (turns == 25)

                return true;
        
            else

                return false;



        }

        bool CheckWinner()
        {

            if ((A00.Text == A01.Text) && (A01.Text == A02.Text)&&(A02.Text == A03.Text) && (A03.Text == A04.Text)&& A00.Text != "")
                return true;
            else if
                ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A12.Text == A13.Text) && (A13.Text == A14.Text) && A10.Text != "")
                return true;
            else if
             ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A22.Text == A23.Text) && (A23.Text == A24.Text) && A20.Text != "")
                return true;
            else if
            ((A30.Text == A31.Text) && (A31.Text == A32.Text) && (A32.Text == A33.Text) && (A33.Text == A34.Text) && A30.Text != "")
                return true;
            else if
            ((A40.Text == A41.Text) && (A41.Text == A42.Text) && (A42.Text == A43.Text) && (A43.Text == A44.Text) && A40.Text != "")
                return true;
            else if
             ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A20.Text == A30.Text) && (A30.Text == A40.Text) && A00.Text != "")
                return true;
            else if
          ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A21.Text == A31.Text) && (A31.Text == A41.Text) && A01.Text != "")
                return true;
            else if
                      ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A22.Text == A32.Text) && (A32.Text == A42.Text) && A02.Text != "")
                return true;
            else if
                     ((A03.Text == A13.Text) && (A13.Text == A23.Text) && (A23.Text == A33.Text) && (A33.Text == A43.Text) && A03.Text != "")
                return true;
            else if
                     ((A04.Text == A14.Text) && (A14.Text == A24.Text) && (A24.Text == A34.Text) && (A34.Text == A44.Text) && A04.Text != "")
                return true;
            else if
                ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A22.Text == A33.Text) && (A33.Text == A44.Text) && A00.Text != "")
                return true;
            else if
              ((A04.Text == A13.Text) && (A13.Text == A22.Text) && (A22.Text == A31.Text) && (A31.Text == A40.Text) && A04.Text != "")
                return true;
            else
                return false;
        }

        private void buttonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (button.Text == "")
            {
               
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;

                }
                else
                {

                    button.Text = "O";
                    player++;
                    turns++;


                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X wygrał!");
                        s1++;
                        NewGame();
                    }

                    else
                    {
                        MessageBox.Show("O wygrał!");
                        s2++;
                        NewGame();


                    }
                }
                if (CheckDraw() == true)
                {

                    MessageBox.Show("Remis!");
                    sd++;

                    NewGame();
                }

             
                
            }


        }

        private void Ebuttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            s1 = 0 ;
            s2 = 0;
            sd = 0;
            NewGame();
            
        }
    }
}
