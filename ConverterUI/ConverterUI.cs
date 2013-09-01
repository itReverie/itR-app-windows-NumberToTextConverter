using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterController;

namespace ChequeProgram
{
    public partial class ChequeConverterUI : Form
    {
        public ChequeConverterUI()
        {
            InitializeComponent();
        }

        private void btnChequeConverter_Click(object sender, EventArgs e)
        {
            try
            {
                double number = 0;
                if (double.TryParse(txtNumber.Text, out number))
                {
                    lblText.Text = Number.ToText(txtNumber.Text);
                }
                else
                {
                    MessageBox.Show("Please type a vaida number.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please type a valid number. Exception:" + exception.Message);
            }
        }
    }
}
