using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);
            lblValue2.Text = Math.Round((amount * Math.Pow((1+ double.Parse(txtRate.Text)),10)),2).ToString();

            int years = 0;
            while (amount < 1000000)
            {
                amount = amount * (1 + double.Parse(txtRate.Text));
                years++;
            }
            lblMillion2.Text = years.ToString();
        }
    }
}
