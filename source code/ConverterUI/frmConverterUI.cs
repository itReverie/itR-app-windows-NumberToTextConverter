using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter;

namespace ConverterUI
{
    /// <summary>
    /// Class to set an interface to test the converter from decimal number to text
    /// </summary>
    public partial class frmConverterUI : Form
    {
        #region Constructor
        public frmConverterUI()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Event to convert a decimal number to text
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                lblText.Text = Number.ToText(txtNumber.Text).ToUpper();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
