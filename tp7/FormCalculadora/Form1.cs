using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculadora
{
    public partial class Form1 : Form
    {
        float operando1;
        float operando2;
        string operador;
        DateTime thisDay = DateTime.Today;

        Calculadora NuevaCalculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                textBox1.Text = textBox1.Text + ",";
                operando1 = float.Parse(textBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "/";
            if (textBox1.Text.Trim() != "")
            {
                operando1 = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operador = "+";
            if (textBox1.Text.Trim() != "")
            {
                operando1 = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operador = "-";
            if (textBox1.Text.Trim() != "")
            {
                operando1 = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operador = "*";
            if (textBox1.Text.Trim() != "")
            {
                operando1 = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                operando2 = float.Parse(textBox1.Text);
                switch (operador)
                {
                    case "+":
                        textBox1.Clear();
                        NuevaCalculadora.OP1 = operando1;
                        NuevaCalculadora.OP2 = operando2;
                        listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Suma()));
                        textBox1.Clear();
                        operando1 = 0;
                        operando2 = 0;
                        NuevaCalculadora = new Calculadora();
                        break;
                    case "-":
                        textBox1.Clear();
                        NuevaCalculadora.OP1 = operando1;
                        NuevaCalculadora.OP2 = operando2;
                        listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Resta()));
                        textBox1.Clear();
                        operando1 = 0;
                        operando2 = 0;
                        NuevaCalculadora = new Calculadora();
                        break;
                    case "*":
                        textBox1.Clear();
                        NuevaCalculadora.OP1 = operando1;
                        NuevaCalculadora.OP2 = operando2;
                        listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Multiplicacion()));
                        textBox1.Clear();
                        operando1 = 0;
                        operando2 = 0;
                        NuevaCalculadora = new Calculadora();
                        break;
                    case "/":
                        if (operando2 == 0)
                        {
                            textBox1.Text = "ERROR: DIVISION EN 0";
                            break;
                        }
                        textBox1.Clear();
                        NuevaCalculadora.OP1 = operando1;
                        NuevaCalculadora.OP2 = operando2;
                        listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Division()));
                        textBox1.Clear();
                        operando1 = 0;
                        operando2 = 0;
                        NuevaCalculadora = new Calculadora();
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           FuncKeysModule(e.KeyData);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        public void FuncKeysModule(Keys value)
        {
            switch (value)
            {
                case Keys.NumPad0:
                    textBox1.Text = textBox1.Text + '0';
                    break;
                case Keys.NumPad1:
                    textBox1.Text = textBox1.Text + '1';
                    break;
                case Keys.NumPad2:
                    textBox1.Text = textBox1.Text + '2';
                    break;
                case Keys.NumPad3:
                    textBox1.Text = textBox1.Text + '3';
                    break;
                case Keys.NumPad4:
                    textBox1.Text = textBox1.Text + '4';
                    break;
                case Keys.NumPad5:
                    textBox1.Text = textBox1.Text + '5';
                    break;
                case Keys.NumPad6:
                    textBox1.Text = textBox1.Text + '6';
                    break;
                case Keys.NumPad7:
                    textBox1.Text = textBox1.Text + '7';
                    break;
                case Keys.NumPad8:
                    textBox1.Text = textBox1.Text + '8';
                    break;
                case Keys.NumPad9:
                    textBox1.Text = textBox1.Text + '9';
                    break;
                case Keys.Decimal:
                    textBox1.Text = textBox1.Text + ",";
                    break;
            }
            
            switch(value)
            { 
                case Keys.Space:
                    textBox1.Clear();
                    break;
                case Keys.Oemplus:
                    operando1 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operador = "+";
                    break;
                case Keys.OemMinus:
                    operando1 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operador = "-";
                    break;
                case Keys.Multiply:
                    operando1 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operador = "*";
                    break;
                case Keys.Divide:
                    operando1 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operador = "/";
                    break;
                case Keys.Enter:
                    if (textBox1.Text.Trim() != "")
                    {
                        textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Count() - 1);
                        operando2 = float.Parse(textBox1.Text);
                        switch (operador)
                        {
                            case "+":
                                NuevaCalculadora.OP1 = operando1;
                                NuevaCalculadora.OP2 = operando2;
                                listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Suma()));
                                textBox1.Clear();
                                operando1 = 0;
                                operando2 = 0;
                                operador = "";
                                NuevaCalculadora = new Calculadora();
                                break;
                            case "-":
                                NuevaCalculadora.OP1 = operando1;
                                NuevaCalculadora.OP2 = operando2;
                                listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Resta()));
                                textBox1.Clear();
                                operando1 = 0;
                                operando2 = 0;
                                operador = "";
                                NuevaCalculadora = new Calculadora();
                                break;     
                            case "*":
                                NuevaCalculadora.OP1 = operando1;
                                NuevaCalculadora.OP2 = operando2;
                                listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Multiplicacion()));
                                textBox1.Clear();
                                operando1 = 0;
                                operando2 = 0;
                                operador = "";
                                NuevaCalculadora = new Calculadora();
                                break;
                            case "/":
                                if (operando2 == 0)
                                {
                                   textBox1.Text = "ERROR: DIVISION EN 0";
                                   break;
                                }
                                NuevaCalculadora.OP1 = operando1;
                                NuevaCalculadora.OP2 = operando2;
                                listBox1.Items.Add(thisDay.ToString("g") + " --> " + operando1 + operador + operando2 + "=" + Convert.ToString(NuevaCalculadora.Division()));
                                textBox1.Clear();
                                operando1 = 0;
                                operando2 = 0;
                                operador = "";
                                NuevaCalculadora = new Calculadora();
                                break;
                        }
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
