using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_cs
{
    public partial class Form1 : Form
    {
        double firstNum, secNum;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBckspace_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0 )
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1); 
            }
            
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnCE_click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;
            f = Convert.ToString(firstNum);
            s = Convert.ToString(secNum);

            f = "";
            s = "";
        }

        private void btnC_click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            
        }

        private void btnPlusMinus_click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }

        private void btn7_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }

        }

        private void btn8Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "";
        }

        private void btn4_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btnSubtract_click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "";
        }

        private void btn1_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btnMultiply_click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "";
        }

        private void btn0_click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnDecimal_click(object sender, EventArgs e)
        {

        }

        private void btnEquals_click(object sender, EventArgs e)
        {
            secNum = double.Parse(txtDisplay.Text);

            switch (oper)
            {
                case "+":
                    txtDisplay.Text = (firstNum + secNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNum * secNum).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (firstNum / secNum).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnDivide_click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
