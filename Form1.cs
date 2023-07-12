using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        int operation = 0;
        int operation2 = 0;


        bool plusIsPressed = false;
        bool minusIsPressed = false;
        bool twiceIsPressed = false;
        bool divideIsPressed = false;

        bool clear_calculator = false;

        //void Update
        public Form1()
        {   
            InitializeComponent();
            add0.Click += new EventHandler(add0_to_calc);
            add1.Click += new EventHandler(add1_to_calc);
            add2.Click += new EventHandler(add2_to_calc);
            add3.Click += new EventHandler(add3_to_calc);
            add4.Click += new EventHandler(add4_to_calc);
            add5.Click += new EventHandler(add5_to_calc);
            add6.Click += new EventHandler(add6_to_calc);
            add7.Click += new EventHandler(add7_to_calc);
            add8.Click += new EventHandler(add8_to_calc);
            add9.Click += new EventHandler(add9_to_calc);
            plus.Click += new EventHandler(plus_to_operation);
            minus.Click += new EventHandler(minus_to_operation);
            divide.Click += new EventHandler(divide_operation);
            twice.Click += new EventHandler(twice_operation);
            equal.Click += new EventHandler(Equal_Calc);
            clear.Click += new EventHandler(clear_calc);
        }

        //calculator buttons
        void add0_to_calc(object sender, EventArgs e)
        {
            if(clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "0";
        }
        void add1_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "1";
        }
        void add2_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "2";
        }
        void add3_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "3";
        }
        void add4_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "4";
        }
        void add5_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "5";
        }
        void add6_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "6";
        }
        void add7_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "7";
        }
        void add8_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "8";
        }
        void add9_to_calc(object sender, EventArgs e)
        {
            if (clear_calculator == true)
            {
                clear_calc(sender, e);
                clear_calculator = false;
            }
            result.Text = result.Text + "9";
        }

        //operation on numbers
        //PLUS
        void plus_to_operation(object sender, EventArgs e)
        {
            minusIsPressed = false;
            twiceIsPressed = false;
            divideIsPressed = false;


            //operation = Convert.ToInt32(result.Text);
            if(result.Text == "")
            {
                ;
            }
            else
            {
                if(plusIsPressed == false)
                {
                    operation = Int32.Parse(result.Text);
                    Console.WriteLine("operation: " + operation);
                    plusIsPressed = true;
                }
            }
            result.Text = "";
        }
        //END OF PLUS

        //MINUS
        void minus_to_operation(object sender, EventArgs e)
        {
            plusIsPressed = false;
            twiceIsPressed = false;
            divideIsPressed = false;

            if (result.Text == "")
            {
                ;
            }
            else
            {
                if (minusIsPressed == false)
                {
                    operation = Int32.Parse(result.Text);
                    Console.WriteLine("operation: " + operation);
                    minusIsPressed = true;
                }
            }
            result.Text = "";
        }
        //END OF MINUS


        //DIVIDE
        void divide_operation(object sender, EventArgs e)
        {
            plusIsPressed = false;
            minusIsPressed = false;
            twiceIsPressed = false;

            if (result.Text == "")
            {
                ;
            }
            else
            {
                if (divideIsPressed == false)
                {
                    operation = Int32.Parse(result.Text);
                    Console.WriteLine("operation: " + operation);
                    divideIsPressed = true;
                }
            }
            result.Text = "";
        }
        //END OF DIVIDE

        //TWICE
        void twice_operation(object sender, EventArgs e)
        {
            plusIsPressed = false;
            minusIsPressed = false;
            divideIsPressed = false;

            if (result.Text == "")
            {
                ;
            }
            else
            {
                if (twiceIsPressed == false)
                {
                    operation = Int32.Parse(result.Text);
                    Console.WriteLine("operation: " + operation);
                    twiceIsPressed = true;
                }
            }
            result.Text = "";
        }
        //END OF TWICE

        //EQUAL
        void Equal_Calc(object sender, EventArgs e)
        {
            if(plusIsPressed == true)
            {
                operation2 = Int32.Parse(result.Text);
                plusIsPressed = false;
                Console.WriteLine("operation2: " + operation2);
                int resultat;
                resultat = operation + operation2;
                result.Text = resultat.ToString();
            }
            if (minusIsPressed == true)
            {
                operation2 = Int32.Parse(result.Text);
                minusIsPressed = false;
                Console.WriteLine("operation2: " + operation2);
                int resultat;
                resultat = (operation - operation2);
                result.Text = resultat.ToString();
            }
            if (divideIsPressed == true && operation != 0 || operation2 != 0)
            {
                operation2 = Int32.Parse(result.Text);
                divideIsPressed = false;
                Console.WriteLine("operation2: " + operation2);
                int resultat;
                resultat = (operation / operation2);
                result.Text = resultat.ToString();
            }
            else
            {
                result.Text = "📸🤨";
            }
            if (twiceIsPressed == true)
            {
                operation2 = Int32.Parse(result.Text);
                twiceIsPressed = false;
                Console.WriteLine("operation2: " + operation2);
                int resultat;
                resultat = (operation * operation2);
                result.Text = resultat.ToString();
            }



            clear_calculator = true;
        }
        //END OF EQUAL

        void clear_calc(object sender, EventArgs e)
        {
            result.Text = "";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        //other buttons
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }


        //void Awake
        private void Form1_Load(object sender, EventArgs e)
        {
            //result.Text = operation.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
