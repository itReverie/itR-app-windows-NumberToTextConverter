using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterUnitTesting
{
    public class ConverterTesting
    {
        public static void Main()
        {

           

            NumbersDictionary numbersDictionary = new NumbersDictionary();
            numbersDictionary.TestingNumbersToText();

            NumberToText numbersToText = new NumberToText();
            numbersToText.TestingNumberToText();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConverterUI());

        }
    }
}
