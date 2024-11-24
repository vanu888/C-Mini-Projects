using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class FrmAgeCalculator : Form
    {
        public FrmAgeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int This_Year, Birth_Year, Age;
            This_Year = Convert.ToInt32(txtThisYear.Text);
            Birth_Year = Convert.ToInt32(txtBirthYear.Text);
            if (This_Year < Birth_Year)
            {
                MessageBox.Show("Invalid year!");
            }
            else
            {
                Age = This_Year - Birth_Year;
                if ((Age < 1) || (Age > 100))
                {
                    MessageBox.Show("Enter real year !");
                }
                else
                {
                    MessageBox.Show("Your age is " + Age);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtThisYear.Clear();
            txtBirthYear.Clear();
        }
    }
}
