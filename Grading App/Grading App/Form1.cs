using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading_App
{
    public partial class FrmGradeApp : Form
    {
        public FrmGradeApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Maths, Science;
            double Total, Avarage;
            Maths = Convert.ToDouble(txtMaths.Text);
            Science = Convert.ToDouble(txtScience.Text);

            if ( (Maths < 0 || Maths >100)  || (Science < 0 || Science >100) ){

                MessageBox.Show("Wrong Marks");
            }
            else{
                   Total = Maths + Science;
                   Avarage = Total / 2;

                   lblTotal.Text = Convert.ToString("Total = "+ Total);
                   lblAvarage.Text = Convert.ToString("Avarage = " + Avarage);

                if (Avarage < 50 ) {
                    lblGrade.Text = Convert.ToString("Fail");
                }
                else{
                    lblGrade.Text = Convert.ToString("Pass");
                }
 
            }

           

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtMaths.Clear();
            txtScience.Clear();
            lblTotal.Text = Convert.ToString("Total");
            lblGrade.Text = Convert.ToString("Grade");
            lblAvarage.Text = Convert.ToString("Avarage");
        }
    }
}
