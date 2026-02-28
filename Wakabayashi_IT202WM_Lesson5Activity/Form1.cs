using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wakabayashi_IT202WM_Lesson5Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrossIncome_Click(object sender, EventArgs e)
        {
            double BIRateperHr, BIHrperCutOff, HIRateperHr, HIHrperCutOff, OIRateperHr, OIHrperCutOff;
            double.TryParse(txtBIRateperHr.Text, out BIRateperHr);
            double.TryParse(txtBIHrperCutoff.Text, out BIHrperCutOff);
            double.TryParse(txtHIRateperHr.Text, out HIRateperHr);
            double.TryParse(txtHIHrperCutoff.Text, out HIHrperCutOff);
            double.TryParse(txtOIRateperHr.Text, out OIRateperHr);
            double.TryParse(txtOIHrperCutoff.Text, out OIHrperCutOff);

            double BIIncomeperCutoff = BIRateperHr * BIHrperCutOff;
            double HIIncomeperCutoff = HIRateperHr * HIHrperCutOff;
            double OIIncomeperCutoff = OIRateperHr * OIHrperCutOff;
            double GrossIncome = BIIncomeperCutoff + HIIncomeperCutoff + OIIncomeperCutoff;

            txtBIIncomeperCutoff.Text = (BIIncomeperCutoff).ToString();
            txtHIIncomeperCutoff.Text = (HIIncomeperCutoff).ToString();
            txtOIIncomeperCutoff.Text = (OIIncomeperCutoff).ToString();
            txtGrossIncome.Text = (GrossIncome).ToString();
        }

        private void btnNetIncome_Click(object sender, EventArgs e)
        {
            double SSSC, PhilHC, PagibigC, ITC, SSSL, PagibigL, FacultyDeposit, FacultyLoan, SalaryLoan, OtherLoan, GrossIncome;
            double.TryParse(txtSSSContribute.Text, out SSSC);
            double.TryParse(txtPhilHContribute.Text, out PhilHC);
            double.TryParse(txtPagibigContribute.Text, out PagibigC);
            double.TryParse(txtIncomeTaxContribute.Text, out ITC);
            double.TryParse(txtSSSLoan.Text, out SSSL);
            double.TryParse(txtPagibigLoan.Text, out PagibigL);
            double.TryParse(txtFacultyDeposit.Text, out FacultyDeposit);
            double.TryParse(txtFacultyLoan.Text, out FacultyLoan);
            double.TryParse(txtSalaryLoan.Text, out SalaryLoan);
            double.TryParse(txtOtherLoan.Text, out OtherLoan);
            double.TryParse(txtGrossIncome.Text, out GrossIncome);
            double TotalDeduction = SSSC + PhilHC + PagibigC + ITC + SSSL + PagibigL + FacultyDeposit + FacultyLoan + SalaryLoan + OtherLoan;
            double NetIncome = GrossIncome - TotalDeduction;
            txtTotalDeduction.Text = (TotalDeduction).ToString();
            txtNetIncome.Text = (NetIncome).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBIRateperHr.Clear();
            txtBIHrperCutoff.Clear();
            txtBIIncomeperCutoff.Clear();
            txtHIRateperHr.Clear();
            txtHIHrperCutoff.Clear();
            txtHIIncomeperCutoff.Clear();
            txtOIRateperHr.Clear();
            txtOIHrperCutoff.Clear();
            txtOIIncomeperCutoff.Clear();
            txtGrossIncome.Clear();
            txtSSSContribute.Clear();
            txtPhilHContribute.Clear();
            txtPagibigContribute.Clear();
            txtIncomeTaxContribute.Clear();
            txtSSSLoan.Clear();
            txtPagibigLoan.Clear();
            txtFacultyDeposit.Clear();
            txtFacultyLoan.Clear();
            txtSalaryLoan.Clear();
            txtOtherLoan.Clear();
            txtTotalDeduction.Clear();
            txtNetIncome.Clear();

        }
    }
}
