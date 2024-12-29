using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private const int METHOD_ADD = 1;
        private const int METHOD_SUB = 2;
        private const int METHOD_MUL = 3;
        private const int METHOD_DIV = 4;

        private int method = 0;
        private int value = 0;
        private int total = 0;

        public Form1()
        {

            InitializeComponent();

            Display();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AllClear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Calc(1);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Calc(2);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Calc(3);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Calc(4);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Calc(5);

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Calc(6);

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Calc(7);

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Calc(8);

        }

        private void button10_Click(object sender, EventArgs e)
        {

            Calc(9);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            Calc(0);

        }

        private void button12_Click(object sender, EventArgs e)
        {

            method = METHOD_ADD;

        }

        private void button13_Click(object sender, EventArgs e)
        {

            method = METHOD_SUB;

        }

        private void button14_Click(object sender, EventArgs e)
        {

            method = METHOD_MUL;

        }

        private void button15_Click(object sender, EventArgs e)
        {

            method = METHOD_DIV;

        }

        private void Calc(int value)
        {

            if (method == METHOD_ADD)
            {

                total += this.value + value;

                Clear();

                Display();

            }
            else if (method == METHOD_SUB)
            {

                total += this.value - value;

                Clear();

                Display();

            }
            else
            {

                this.value = value;

            }

        }

        private void Display()
        {

            label1.Text = total.ToString();

        }

        private void Clear()
        {

            value = 0;
            method = 0;

        }

        private void AllClear()
        {

            Clear();

            total = 0;

            Display();

        }

    }

}
