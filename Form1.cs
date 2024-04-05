using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_3
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        double FirstNumber;
        double SecondNumber;
        string Operation;
        int    result;

        string ZERO            = "0";
        string ADDITION        = "+";
        string SUBTRACTION     = "-";
        string MULTIPLICATION  = "*";
        string DIVISION        = "/";
        string POINT           = ".";

        private void DisplayTotalTextBox(string nummberText)
        {
            if (TotaltextBox.Text == ZERO)
                TotaltextBox.Clear();

            TotaltextBox.Text = TotaltextBox.Text + nummberText;
        }

        //NUMBERS BUTTONS
        private void OneButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(onebutton.Text);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(twobutton.Text);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(threebutton.Text);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(fourbutton.Text);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(fivebutton.Text);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(sixbutton.Text);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(sevenbutton.Text);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(eightbutton.Text);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(ninebutton.Text);
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            DisplayTotalTextBox(zerobutton.Text);
        }

        //CLEAR BUTTON
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TotaltextBox.Clear();
            result        = 0;
            FirstNumber   = 0;
            SecondNumber  = 0;
            TotaltextBox.Text = ZERO;
        }

        //DELETE BUTTON
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int length = TotaltextBox.TextLength - 1;
            string text = TotaltextBox.Text;
            TotaltextBox.Clear();
            for (int i = 0; i < length; i++)
            {
                TotaltextBox.Text = TotaltextBox.Text + text [i] ;
            }
            if (TotaltextBox.Text == "")
            {
                TotaltextBox.Text = ZERO;
            }
        }

        private void OperatorsButton(string Operators)
        {
            FirstNumber = double.Parse(TotaltextBox.Text);

            TotaltextBox.Text = ZERO;
        }

        //OPERATORS BUTTONS
        private void AddButton_Click(object sender, EventArgs e)
        {
            OperatorsButton (Operation = ADDITION);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OperatorsButton (Operation = SUBTRACTION);
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            OperatorsButton (Operation = MULTIPLICATION);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
           OperatorsButton (Operation = DIVISION);        }
        
        //EQUALS BUTTON
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result = 0;

            SecondNumber = Convert.ToDouble(TotaltextBox.Text);
     
            if (Operation == ADDITION)
            {
                Result = Add(FirstNumber, SecondNumber);
            }

            if (Operation == SUBTRACTION)
            {
                Result = Subtract(FirstNumber, SecondNumber);
            }

            if (Operation == MULTIPLICATION)
            {
                Result = Multiply(FirstNumber, SecondNumber);
            }

            if (Operation == DIVISION)
            {
                Result = Divide(FirstNumber, SecondNumber);
            }
            TotaltextBox.Text = Convert.ToString(Result);
        }

        private double Multiply(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;  
        }

        private double Subtract(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        private double Divide(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber; 
        }

        private double Add(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;

        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (!TotaltextBox.Text.Contains(POINT))
                if (TotaltextBox.Text == string.Empty)
                    TotaltextBox.Text = ZERO;
                else
                    TotaltextBox.Text += POINT;
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}