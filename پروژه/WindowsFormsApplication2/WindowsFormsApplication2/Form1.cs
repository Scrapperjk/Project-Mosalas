﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = 0,M=0,M1=0,A1=0;

            if (textBox1.Text == " " && textBox2.Text == " " && textBox3.Text == " ")
                MessageBox.Show("Eroor");

            double Alpha = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox3.Text);
            M=Math.Pow(B,2);
            M1 = Math.Pow(C, 2);
            A = (M + M1) - 2;
            A1 = Math.Cos(Alpha);
            A *= B * C * A1;
            A = Math.Pow(A, 2);
            MessageBox.Show("Zele Sevom =" + A);


        }
    }
}
