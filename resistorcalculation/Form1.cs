using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resistorcalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float R = 0.0f;
        public float U = 0.0f;
        public float I = 0.0f;
        public float P = 0.0f;

        private void button1_Click(object sender, EventArgs e)
        {
            //stiind tensiunea U si curentul I calculeaza Rezistenta R in Ohmi [omega][gre] dupa formula
            //R = U/I
            try
            {
                U = (float)Convert.ToDouble(txtU.Text);
            }
            catch { }
            try
            {
                I = (float)Convert.ToDouble(txtI.Text);
            }
            catch { }
            try
            {
                R = U / I;
            }
            catch { }
            txtR.Text = R.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stiind rezistenta R si curentul I calculeaza Tensiunea U in Volti [V] dupa formula
            //U = R * I
            try
            {
                R = (float)Convert.ToDouble(txtR.Text);
            }
            catch { }
            try
            {
                I = (float)Convert.ToDouble(txtI.Text);
            }
            catch { }
            try
            {
                U = R * I;
            }
            catch { }
            txtU.Text = U.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stiind rezistenta R si tensiune U calculeaza curentul I in Amperi [A] dupa formula
            //I = U / R
            try
            {
                R = (float)Convert.ToDouble(txtR.Text);
            }
            catch { }
            try
            {
                U = (float)Convert.ToDouble(txtU.Text);
            }
            catch { }
            try
            {
                I = U / R;
            }
            catch { }
            txtI.Text = I.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //stiind curentul I si tensiune U calculeaza puterea P in wati [watt][W] dupa formula
            //P = I * U 
            try
            {
                I = (float)Convert.ToDouble(txtI.Text);
            }
            catch { }
            try
            {
                U = (float)Convert.ToDouble(txtU.Text);
            }
            catch { }
            try
            {
                P = U * I;
            }
            catch { }
            txtP.Text = P.ToString();
        }
    }
}
