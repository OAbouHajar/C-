using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace lab1
{
    
    public partial class Form1 : Form
    {
        
        public double convert(double converter, string choice)
        {
            double number = Convert.ToDouble(txtinput.Text);
            double result = 0;

            if (choice == "m")
            {
                result = number * converter;
            }
            else if (choice == "d")
            {
                result = number / converter;
            }

            return result;
        }

        public double celAndFahr(string choice)
        {
            double number = Convert.ToDouble(txtinput.Text);
            double result = 0;
            if (choice == "f")
            {
                result = (number - 32) * 5 / 9;
            }
            else if (choice == "c")
            {
                result = (number * 9 / 5) + 32;
            }
            return result;
        }
      
        

        public Form1()
        {
            InitializeComponent();
            
        }

     
        
     

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rdbtnPtoE.Checked == true)
            {

                txtResults.Text = Convert.ToString(convert(0.79, "d"));
            }
            if (rdbtnEtoP.Checked == true)
            {
               
                txtResults.Text = Convert.ToString(convert(0.79, "m"));
            }
            if (rdtbnFeetToInches.Checked == true)
            {

                txtResults.Text = Convert.ToString(convert(12, "m"));
            }
            if (rdbtnInchesToFeet.Checked == true)
            {

                txtResults.Text = Convert.ToString(convert(12, "d"));
            }

            if (rdbtnFahrToCel.Checked == true)
                txtResults.Text = Convert.ToString(celAndFahr("f"));
            if (rdbtnCelToFahr.Checked == true)
                txtResults.Text = Convert.ToString(celAndFahr("c"));



        }
    }
}
