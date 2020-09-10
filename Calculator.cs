/*
 * Author: Ryan Danielson
 * Class: CSC260
 * Teacher: Jason Jenkins
 * Due: 9/2/2020
 * Assignment: Calculator
 * Description: This is a calculator built using C# and windows forms. It has the functionality
 *              expected from a basic calculator. There are many edge-cases to consider
 *              so there's lots of branching going on in otherwise simple functions. Function names
 *              should be descriptive enough as to not warrant a ton of unnecessary commentary.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260_Calculator
{
    public partial class Calculator : Form
    {
        private enum operations
        {
            MULTIPLICATION,
            DIVISION,
            ADDITION,
            SUBTRACTION,
            SQUARE,
            EXPONENT,
            SQRT,
            INVERSE,
            FLIPSIGN,
            EQUALS
        };

        private bool solved = true;                             /* used for tracking user input and clearing the display box accordinly */
        private double tempStore;                               /* used for temporarily storing input to be computed */
        private int lastOperation = (int)operations.EQUALS;     /* for keeping track of the previous operation to help keep track of state */  

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress += Calculator_KeyPress;
        }

        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 13:    // enter
                    BEquals_click(bEquals, e);
                    break;
                case 42:    // *
                    BMultiply_click(bMultiply, e);
                    break;
                case 47:    // /
                    BDivide_click(bDivide, e);
                    break;
                case 43:    // +
                    BAdd_click(bAdd, e);
                    break;
                case 45:    // -
                    BSubtract_click(bSubtract, e);
                    break;
                case 46:    // .
                    BDecimal_click(bDecimal, e);
                    break;
                case 94:    // ^
                    BExponent_click(bExponent, e);
                    break;
                case 48:
                    B0_click(b0, e);
                    break;
                case 49:
                    B1_click(b1, e);
                    break;
                case 50:
                    B2_click(b2, e);
                    break;
                case 51:
                    B3_click(b3, e);
                    break;
                case 52:
                    B4_click(b4, e);
                    break;
                case 53:
                    B5_click(b5, e);
                    break;
                case 54:
                    B6_click(b6, e);
                    break;
                case 55:
                    B7_click(b7, e);
                    break;
                case 56:
                    B8_click(b8, e);
                    break;
                case 57:
                    B9_click(b9, e);
                    break;
                default:
                    break;
            }
        }

        private void BEquals_click(object sender, EventArgs e)
        {
            /* all statements are variations on the same theme, their differences are just
             * to account for the way the string will be displayed in the calculator
             * after "=" is selected depending on the operations performed. All will be moved to
             * the entryHistory box after "=" is selected.
             */

            if (lastOperation == (int)operations.MULTIPLICATION
                || lastOperation == (int)operations.DIVISION
                || lastOperation == (int)operations.ADDITION
                || lastOperation == (int)operations.SUBTRACTION
                || lastOperation == (int)operations.EXPONENT)
            {
                bHistoryBox.Text += bDisplayBox.Text + "=";
                SolveOperation();
                entryHistory.AppendText(bHistoryBox.Text + bDisplayBox.Text + Environment.NewLine + Environment.NewLine);
                lastOperation = (int)operations.EQUALS;
                solved = true;
            }
            else if (lastOperation == (int)operations.SQRT
                     || lastOperation == (int)operations.SQUARE
                     || lastOperation == (int)operations.INVERSE
                     || bDisplayBox.Text.Length == 0)
            {
                SolveOperation();
                bHistoryBox.Text += '=';
                entryHistory.AppendText(bHistoryBox.Text + bDisplayBox.Text + Environment.NewLine + Environment.NewLine);
                solved = true;
            } 
            else if (lastOperation != (int)operations.EQUALS)
            {
                SolveOperation();
                if (!bHistoryBox.Text.Contains('=') && bDisplayBox.Text.Length != 0)
                {
                    bHistoryBox.Text += '=';
                }
                entryHistory.AppendText(bHistoryBox.Text + bDisplayBox.Text + Environment.NewLine + Environment.NewLine);
                solved = true;
            } 
            else if (lastOperation == (int)operations.SQRT
                     || lastOperation == (int)operations.SQUARE
                     || lastOperation == (int)operations.INVERSE)
            {
                entryHistory.AppendText(bHistoryBox.Text + "=" + bDisplayBox.Text + Environment.NewLine + Environment.NewLine);
                solved = true;
            }
            lastOperation = (int)operations.EQUALS;
        }

        private void BSqrt_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (bDisplayBox.Text.StartsWith("-"))
                {
                    string temp = bHistoryBox.Text;
                    bHistoryBox.Text = "Invalid input";
                }
                else
                {
                    if (lastOperation == (int)operations.SQRT || lastOperation == (int)operations.SQUARE || solved)
                    {
                        bHistoryBox.Clear();
                        solved = false;
                    }
                    bHistoryBox.Text += "Sqrt(" + bDisplayBox.Text + ")";
                    bDisplayBox.Text = Math.Sqrt(StringToInt(bDisplayBox.Text)).ToString();
                    tempStore = StringToInt(bDisplayBox.Text);
                    lastOperation = (int)operations.SQRT;
                }
            }
        }

        private void BSquare_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (lastOperation == (int)operations.SQUARE || lastOperation == (int)operations.SQRT 
                    || lastOperation == (int)operations.MULTIPLICATION || lastOperation == (int)operations.DIVISION
                    || lastOperation == (int)operations.ADDITION || lastOperation == (int)operations.SUBTRACTION 
                    || solved)
                {
                    bHistoryBox.Clear();
                    solved = false;
                }

                bHistoryBox.Text += "sqr(" +bDisplayBox.Text + ")";
                bDisplayBox.Text = Math.Pow(StringToInt(bDisplayBox.Text), 2).ToString();
                tempStore = StringToInt(bDisplayBox.Text);
                lastOperation = (int)operations.SQUARE;
            }
        }
        private void BExponent_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0 && lastOperation != (int)operations.EXPONENT)
            {
                if (solved || lastOperation == (int)operations.SQRT || lastOperation == (int)operations.SQUARE)
                {
                    bHistoryBox.Clear();
                }
                SolveOperation();
                bHistoryBox.Text += bDisplayBox.Text + "^";
                tempStore = StringToInt(bDisplayBox.Text);
                lastOperation = (int)operations.EXPONENT;
                solved = true;
            }
        }

        private void SolveExponents()
        {
            bDisplayBox.Text = Math.Pow(tempStore, StringToInt(bDisplayBox.Text)).ToString();
        }

        private void BInverse_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                SolveOperation();
                bHistoryBox.Text = "1/" + bDisplayBox.Text;
                bDisplayBox.Text = (1 / StringToInt(bDisplayBox.Text)).ToString();
                lastOperation = (int)operations.INVERSE;
            }
        }
        private void BFlip_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (solved || lastOperation == (int)operations.SQRT || lastOperation == (int)operations.SQUARE)
                {
                    bHistoryBox.Clear();
                }
                if (bDisplayBox.Text.StartsWith("-"))
                    bDisplayBox.Text = bDisplayBox.Text.Remove(0, 1);
                else
                    bDisplayBox.Text = "-" + bDisplayBox.Text;
            }
        }

        private void BClearEntry_click(object sender, EventArgs e)
        {
            bDisplayBox.Clear();
            solved = true;
        }

        private void BClear_click(object sender, EventArgs e)
        {
            bDisplayBox.Clear();
            bHistoryBox.Clear();
            tempStore = 0;
            solved = true;
        }

        private void BDelete_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length > 0)
                bDisplayBox.Text = bDisplayBox.Text.Remove(bDisplayBox.Text.Length-1, 1);
        }
        private void BMultiply_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (lastOperation == (int)operations.EQUALS)
                {
                    bHistoryBox.Clear();
                    bHistoryBox.Text += bDisplayBox.Text + "*";
                    tempStore = StringToInt(bDisplayBox.Text);
                }
                else if (lastOperation == (int)operations.SQUARE || lastOperation == (int)operations.SQRT)
                    bHistoryBox.Text += "*";
                else
                    bHistoryBox.Text += bDisplayBox.Text + "*";

                SolveOperation();
                tempStore = StringToInt(bDisplayBox.Text);
                bDisplayBox.Clear();
                lastOperation = (int)operations.MULTIPLICATION;
            }
        }
        
        private void SolveMultiplication()
        {
            bDisplayBox.Text = (tempStore * StringToInt(bDisplayBox.Text)).ToString();
        }
        private void BDivide_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (lastOperation == (int)operations.EQUALS)
                {
                    bHistoryBox.Clear();
                    bHistoryBox.Text += bDisplayBox.Text + "/";
                    tempStore = StringToInt(bDisplayBox.Text);
                }
                else if (lastOperation == (int)operations.SQUARE || lastOperation == (int)operations.SQRT)
                    bHistoryBox.Text += "/";
                else
                    bHistoryBox.Text += bDisplayBox.Text + "/";


                SolveOperation();
                tempStore = StringToInt(bDisplayBox.Text);
                bDisplayBox.Clear();
                lastOperation = (int)operations.DIVISION;
            }
        }

        private void SolveDivision()
        {
            if (!DivisionByZero())
                bDisplayBox.Text = (tempStore / StringToInt(bDisplayBox.Text)).ToString();
            else
                bDisplayBox.Text = "Cannot divide by zero.";
        }
        private bool DivisionByZero()
        {
            return StringToInt(bDisplayBox.Text) == 0;
        }

        private void BAdd_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (lastOperation == (int)operations.EQUALS)
                {
                    bHistoryBox.Clear();
                    bHistoryBox.Text += bDisplayBox.Text + "+";
                    tempStore = StringToInt(bDisplayBox.Text);
                }
                else if (lastOperation == (int)operations.SQUARE || lastOperation == (int)operations.SQRT)
                    bHistoryBox.Text += "+";
                else
                    bHistoryBox.Text += bDisplayBox.Text + "+";

                SolveOperation();
                tempStore = StringToInt(bDisplayBox.Text);
                bDisplayBox.Clear();
                lastOperation = (int)operations.ADDITION;
            }
        }

        private void SolveAddition()
        {
            bDisplayBox.Text = (tempStore + StringToInt(bDisplayBox.Text)).ToString();
        }

        private void BSubtract_click(object sender, EventArgs e)
        {
            if (bDisplayBox.Text.Length != 0)
            {
                if (lastOperation == (int)operations.EQUALS)
                {
                    bHistoryBox.Clear();
                    bHistoryBox.Text += bDisplayBox.Text + "-";
                    tempStore = StringToInt(bDisplayBox.Text);
                }
                else if (lastOperation == (int)operations.SQUARE || lastOperation == (int)operations.SQRT)
                    bHistoryBox.Text += "-";
                else
                    bHistoryBox.Text += bDisplayBox.Text + "-";

                SolveOperation();
                tempStore = StringToInt(bDisplayBox.Text);
                bDisplayBox.Clear();
                lastOperation = (int)operations.SUBTRACTION;
            }
        }

        private void SolveSubtraction()
        {
            bDisplayBox.Text = (tempStore - StringToInt(bDisplayBox.Text)).ToString();
        }

        private void B0_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "0";
        }

        private void B1_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "1";
        }
        private void B2_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "2";
        }
        private void B3_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "3";
        }
        private void B4_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "4";
        }
        private void B5_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "5";
        }
        private void B6_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "6";
        }
        private void B7_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "7";
        }
        private void B8_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "8";
        }
        private void B9_click(object sender, EventArgs e)
        {
            if (solved)
            {
                bDisplayBox.Clear();
                solved = false;
            }
            bDisplayBox.Text += "9";
        }

        private void BDecimal_click(object sender, EventArgs e)
        {
            /* search for previous decimal, two's too many! */
            if (!bDisplayBox.Text.Contains(".") && bDisplayBox.Text.Length != 0)
                bDisplayBox.Text = bDisplayBox.Text + ".";
        }

        private void SolveOperation()
        {
            /* find the last unsolved operation and solve it, this is necessary due to the way the calculator was implemented;
             * solving most problems in two-parts allows us to calculate as the calculator receives new input from the user.
             * For instance, every time a new operator is pressed, the previous statement is solved and moved to bHistoryBox.
             */
            if (bDisplayBox.Text.Length > 0)
            {
                if (lastOperation == (int)operations.MULTIPLICATION)
                    SolveMultiplication();
                else if (lastOperation == (int)operations.DIVISION)
                    SolveDivision();
                else if (lastOperation == (int)operations.ADDITION)
                    SolveAddition();
                else if (lastOperation == (int)operations.SUBTRACTION)
                    SolveSubtraction();
                else if (lastOperation == (int)operations.EXPONENT)
                    SolveExponents();
            }
        }
       
        private double StringToInt(string numbers)
        {
            return double.Parse(numbers);
        }
        
        private bool CheckCalculation(double number)
        {
            return (number <= double.MaxValue && number >= double.MinValue ? true : false); 
        }
    }
}
