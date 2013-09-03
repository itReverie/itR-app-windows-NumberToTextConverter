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

namespace TestingConverter
{
    public partial class frmConverterUI : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor for the UI of the converter.
        /// </summary>
        public frmConverterUI()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Converts the input number in text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChequeConverter_Click(object sender, EventArgs e)
        {
            try
            {
               lblText.Text = Number.ToText(txtNumber.Text).ToUpper();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnStressTESTING_Click(object sender, EventArgs e)
        {
            NumberToText_Performance performanceTesting = new NumberToText_Performance();
            performanceTesting.TestingPerformance();

            NumberToText_Integers testingIntegers = new NumberToText_Integers();
            testingIntegers.IntegersCorrectInputs();


        }
        #endregion
    }
}
