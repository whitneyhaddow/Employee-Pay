using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whitney_Haddow___Lab_1___Employee_Pay

    /***************************************************
     * This form calculates weekly pay for an employee
     * based on hours worked and pay rate
     * Created September 2014 by Whitney Haddow
    ****************************************************/

{
    public partial class frmEmployeePay : Form
    {
        
        public frmEmployeePay()
        {
            InitializeComponent();
        }

        private void frmEmployeePay_Load(object sender, EventArgs e)
        {

        }

        // calculates employee's regular, overtime, and total pay
        private void btnCalculate_Click(object sender, EventArgs e)
        {

        //declare variables
            decimal hoursWorked; //number of hours worked for the week
            decimal rate; //rate per hour for that employee
            decimal overtimeRate; //rate for overtime hours (time and a half)
            decimal regularPay; //total pay for regular hours (up to 37.5 hrs)
            decimal overtimeHours; //number of hours worked overtime
            decimal overtimePay; //pay for overtime hours
            decimal totalPay; //total pay for the employee for that week

        //get inputs
            hoursWorked = Convert.ToDecimal(txtHours.Text);
            rate = Convert.ToDecimal(txtRate.Text);
            overtimeRate = rate * 1.5m;
            overtimeHours = hoursWorked - 37.5m;

        //perform calculations
            if (hoursWorked <= 37.5m) //calculates pay when the employee does not work any overtime
            {   
                regularPay = hoursWorked * rate;
                overtimePay = 0m;
                totalPay = regularPay;
            }

            else //calculates pay when employee works overtime
            {
                regularPay = rate * 37.5m;
                overtimePay = overtimeHours * overtimeRate;
                totalPay = regularPay + overtimePay;
            }

            //display results in currency format
            lblRegularPay.Text = String.Format("{0:c}", regularPay);
            lblOvertime.Text = String.Format("{0:c}", overtimePay);
            lblTotalPay.Text = String.Format("{0:c}", totalPay);

        }

        
        //clear user inputs and results
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtRate.Text = "";
            lblRegularPay.Text = ""; 
            lblOvertime.Text = "";
            lblTotalPay.Text = "";
            txtHours.Focus(); //place focus on text box

        }

        
        //closes application when clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
       
    }
}
