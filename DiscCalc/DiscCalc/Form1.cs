using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //radFreq.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double answer;
            if (txtSubtotal.Text == "")
            {
                MessageBox.Show("No subtotal! Oh no!");
            }
            else
            {
                double subtotal = Convert.ToDouble(txtSubtotal.Text);

                if (subtotal >= 0)
                {
                    //double answer;
                    //double subtotal = Convert.ToDouble(txtSubtotal.Text);                

                    if (radMisc.Checked == true)
                    {
                        if (txtMisc.Text == "")
                        {
                            MessageBox.Show("No value!");
                        }
                        else
                        {
                            double miscel = Convert.ToDouble(txtMisc.Text);
                            double temp = (miscel / 100);

                            answer = subtotal * temp;
                            lblAmount.Text = answer.ToString("0.00");
                        }
                    }
                    else if (radEmp.Checked == true)
                    {
                        answer = subtotal * .30;
                        lblAmount.Text = answer.ToString("0.00");
                    }
                    else if (radFreq.Checked == true)
                    {
                        answer = subtotal * .20;
                        lblAmount.Text = answer.ToString("0.00");
                    }
                    else if (radK2k.Checked == true)
                    {
                        answer = subtotal * .15;
                        lblAmount.Text = answer.ToString("0.00");
                    }
                    else if (radMil.Checked == true)
                    {
                        answer = subtotal * .10;
                        lblAmount.Text = answer.ToString("0.00");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a positive integer");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtMisc.Clear();
            radFreq.Focus();
            lblAmount.Text = " ";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discount Calculator" + Environment.NewLine + "Designed by Alex Brassell" +
                Environment.NewLine + "©Copyright 2014");
        }
    }
}
