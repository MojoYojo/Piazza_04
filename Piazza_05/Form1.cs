using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piazza_05
{
    public partial class Form1 : Form
    {

        public double first = 0, second = 0, result = 0, data = 0;
        public string operation = "";
        public bool resulted = false, resultClickedAgain = false, noOperation = true, differentOperation = false, dotIsSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.Text = "0";
            Memory.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void num_Click(object sender, EventArgs e)
        {            
            if (resulted)
            {
                display.Text = "0";
                dotIsSet = false;
                resulted = false;
            }
            
            Button btn = sender as Button;
            if(btn != Dot)
            {
                if (display.Text[0] != '0' || (display.Text[0] == '0' && display.Text.Length>1))
                    display.Text += btn.Text;
                else
                    display.Text = btn.Text;
            }
            else
            {
                if(!dotIsSet)
                {
                    display.Text += btn.Text;
                    dotIsSet = true;
                }
            }
            
        }

        private void memory_Click(object sender, EventArgs e)
        {
            resulted = true;
            Button btn = sender as Button;
            if (btn == MC)
            {
                if (Memory.Text == "M")
                    Memory.Text = "";
                data = 0;
            }
            else if (btn == MR)
            {
                display.Text = data.ToString();
            }
            else if (btn == MS)
            {
                if(Memory.Text == "")
                    Memory.Text = "M";
                data = double.Parse(display.Text);
            }
            else if (btn == MP)
            {
                data += double.Parse(display.Text);
            }
            else if (btn == MM)
            {
                data -= double.Parse(display.Text);
            }
        }

        private void degree_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == Square)
            {
                display.Text = Math.Pow(double.Parse(display.Text), 2.0).ToString();
            }
            else if (btn == Cube)
            {
                display.Text = Math.Pow(double.Parse(display.Text), 3.0).ToString();
            }
            else if (btn == Sqrt)
            {
                display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
            }
            else if (btn == Factorial)
            {
                long count = 1;
                for (int accelerator = int.Parse(display.Text); accelerator >= 1; accelerator--)
                    count *= accelerator;
                display.Text = count.ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn == Clear)
            {
                resulted = true;
                noOperation = true;
                resultClickedAgain = false;
                differentOperation = false;
                display.Text = "0";
                first = 0;
                second = 0;
                result = 0;
            }
            else if(btn == Backspace)
            {
                if (display.Text.Length > 1)
                    display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                else
                    display.Text = "0";

                if (!display.Text.Contains(","))
                    dotIsSet = false;
            }
        }

        private void surprise_Click(object sender, EventArgs e)
        {
            second = 0;
            display.Text = "0";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operation = btn.Text;
            first = double.Parse(display.Text);
            second = double.Parse(display.Text);
            resulted = true;
            noOperation = false;
            differentOperation = true;
        }

        private void result_click(object sender, EventArgs e)
        {
            resulted = true;
            if (!noOperation)
            {
                if (!resultClickedAgain || differentOperation)
                    second = double.Parse(display.Text);
                switch (operation)
                {
                    case "+":
                        if (!resultClickedAgain)
                            result += first + second;
                        else
                            result += second;
                        break;
                    case "-":
                        if (!resultClickedAgain)
                            result += first - second;
                        else
                            result -= second;
                        break;
                    case "*":
                        if (!resultClickedAgain)
                            result += first * second;
                        else
                            result *= second;
                        break;
                    case "/":
                        if (!resultClickedAgain)
                            result += first / second;
                        else
                            result /= second;
                        break;
                    case "x^y":
                        if (!resultClickedAgain)
                            result = Math.Pow(first, second);
                        else
                            result = Math.Pow(result, second);
                        break;
                    default:
                        break;
                }
                display.Text = result.ToString();
                if (!resultClickedAgain)
                    resultClickedAgain = true;
                differentOperation = false;
            }
        }

    }
}
