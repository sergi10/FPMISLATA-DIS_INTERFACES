using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private int operando1;
        private int operando2;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = "";
            operando1 = 0;
            operando2 = 0;
            operacion = 0;
        }
        private void clear_display()
        {
            labelResult.Text = "";
        }
        private void buttonClear_clicked(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void button0_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "0";
        }
        private void button1_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "1";
        }
        private void button2_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "2";
        }
        private void button3_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "3";
        }
        private void button4_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "4";
        }
        private void button5_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "5";
        }
        private void button6_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "6";
        }
        private void button7_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "7";
        }
        private void button8_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "8";
        }
        private void button9_clicked(object sender, EventArgs e)
        {
            labelResult.Text += "9";
        }
        private void buttonSuma_clicked(object sender, EventArgs e)
        {
            operando1 = Int32.Parse( labelResult.Text);
            operacion = 1;
            clear_display();
        }
        private void buttonResta_clicked(object sender, EventArgs e)
        {
            operando1 = Int32.Parse(labelResult.Text);
            operacion = 2;
            clear_display();
        }
        private void buttonMulti_clicked(object sender, EventArgs e)
        {
            operando1 = Int32.Parse(labelResult.Text);
            operacion = 3;
            clear_display();
        }
        private void buttonDiv_clicked(object sender, EventArgs e)
        {
            operando1 = Int32.Parse(labelResult.Text);
            operacion = 4;
            clear_display();
        }

        private void buttonCalcular_clicked(object sender, EventArgs e)
        {
            operando2 = Int32.Parse(labelResult.Text);
            int resultado = operando1;

            labelResult.Text = resultado.ToString();
        }
    }
}
