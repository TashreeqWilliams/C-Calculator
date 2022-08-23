using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*float[] therealnumber*/
        float num1, ans;
        int count;
        List<float> nums = new List<float>(); 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = "";
            textBox_Result.Text = String.Empty;
            textBox_Result.Focus();

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }


        private void buttonOne_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
           
            num1 = float.Parse(textBox_Result.Text);
            label1.Text = textBox_Result + "x";
            textBox_Result.Clear();
            textBox_Result.Focus();
            count = 3;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonDoubleZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = button.Text;
            textBox_Result.Text = textBox_Result.Text + button.Text;
            textBox_Result.Focus();

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            label1.Text = textBox_Result.Text + "÷";
            num1 = float.Parse(textBox_Result.Text);
            textBox_Result.Clear();
            count = 4;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
            if (textBox_Result.Text != "")
            {
                nums.Add(Convert.ToInt32(textBox_Result.Text));
                textBox_Result.Clear();
                textBox_Result.Focus();
                count = 1;
            } 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            num1 = float.Parse(textBox_Result.Text);
            textBox_Result.Clear();
            textBox_Result.Focus();
            count = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void compute(int count)
        {
            
            switch (count)

            {
                case 1:
                    nums.Add(Convert.ToInt32(textBox_Result.Text));
                    float answer = 0;

                    for (int i = 0; i < nums.Count; i++)
                    {
                        
                        answer = nums[0] - nums[i];
                       
                    }
                    label1.Text = label1.Text + "=" + answer.ToString();
                    break;
                case 2:
                    string[] parts = label1.Text.Split('+','-','*','/');
                    int intSum = 0;
                    foreach (string item in parts)
                    {
                        intSum = intSum + Convert.ToInt32(item);
                    }
                    label1.Text = label1.Text + "=" + intSum.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox_Result.Text);
                    textBox_Result.Text = ans.ToString();
                    label1.Text = label1.Text + ans;
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox_Result.Text);
                    textBox_Result.Text = ans.ToString();
                    label1.Text = label1.Text + ans;
                    break;
                default:
                    break;

            }
        }
    }
}
