using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraAPPForms
{
    public partial class Form1 : Form
    {

        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.clssuma obj = new Clases.clssuma();
        Clases.clsresta obj2 = new Clases.clsresta();
        Clases.clsmulti obj3 = new Clases.clsmulti();
        Clases.clsdivi obj4 = new Clases.clsdivi();
        Clases.clsporsentaje obj5 = new Clases.clsporsentaje();

        private void btn0_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            Txtscreem.Text = Txtscreem.Text + ".";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Txtscreem.Text);
            Txtscreem.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Txtscreem.Text);
            Txtscreem.Clear();
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Txtscreem.Text);
            Txtscreem.Clear();
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Txtscreem.Text);
            Txtscreem.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Txtscreem.Text);

            double sum;
            double res;
            double mul;
            double div;
            double por;

            switch (operador)
            {
                case "+":
                    sum = obj.sumar((primero), (segundo));
                    Txtscreem.Text = sum.ToString();
                    break;

                case "-":
                    res = obj2.restar((primero), (segundo));
                    Txtscreem.Text = res.ToString();
                    break;

                case "*":
                    mul = obj3.multi((primero), (segundo));
                    Txtscreem.Text = mul.ToString();
                    break;

                case "/":
                    div = obj4.divi((primero), (segundo));
                    Txtscreem.Text = div.ToString();
                    break;

                case "%":
                    por = obj5.porsentaje((primero), (segundo));
                    Txtscreem.Text = por.ToString();
                    break;

            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Txtscreem.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (Txtscreem.Text.Length == 1)
                Txtscreem.Text = "";
            else
                Txtscreem.Text = Txtscreem.Text.Substring(0, Txtscreem.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(Txtscreem.Text);
            Txtscreem.Clear();
        }
    }
}
