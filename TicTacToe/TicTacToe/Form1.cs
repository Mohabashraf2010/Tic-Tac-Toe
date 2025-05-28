using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Varaible Declaration
        Boolean check;
        int counter;

        public Form1()
        {
            counter =0;
            check = false;
            InitializeComponent();

            foreach(Button b in panel1.Controls)
            {
                b.Click += button_Click;
            }
        }
        public void allButtonsToFalse()
        {
            //All buttons are set to False
          foreach(Button b in panel1.Controls)
            {
                b.Enabled = false;
            }
            
        }
        public void doOperation(string winner,Label label)
        {
            //1st Step:
            MessageBox.Show($"Player {winner} is the winner","TicTacToe");
            
            //2nd Step:
            counter = int.Parse(label.Text);
            counter++;
            label.Text = counter.ToString();

            //3rd Step:
            allButtonsToFalse();
        }
        public void winningCalculations()
        {
            //Player X:
            //Row wise:
            if(button1.Text=="X" &&button2.Text=="X" && button3.Text=="X")
            {
                doOperation("X",_playerXScore);
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            //Col wise:
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            //Diagonal wise:
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                doOperation("X", _playerXScore);
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                doOperation("X", _playerXScore);
            }

            //Player O:
            //Row wise:
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            //Col wise:
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            //Diagonal wise:
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                doOperation("O", _playerOScore);
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                doOperation("O", _playerOScore);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if(b.Text=="")
            {
                b.Text = check ? "O" : "X";
                check = !check;
            }
            winningCalculations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach(Button b in panel1.Controls)
            {
                b.Text = "";
                b.Enabled = true;
            }
            winningCalculations();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
