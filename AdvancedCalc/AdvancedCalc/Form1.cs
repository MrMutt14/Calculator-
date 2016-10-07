using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sum;
        private void btnplus_Click(object sender, EventArgs e)
        {
            
            sum = double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text);
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            
            sum = double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text);
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            
            sum = double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text);
        }

        private void btndvide_Click(object sender, EventArgs e)
        {
            
            sum = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
        }

        private void btnByitself_Click(object sender, EventArgs e)
        {
            
            sum = Power(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
        }
        public double Power(double num1,double num2)
        {
            double retur = 0;
            for (int i =0;i < num2; i++)
            {

                retur = num1 * num1;
                retur = retur * retur;
            }
            
            return retur;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {            
            textBox1.Text = sum.ToString();
        }
    }
}
