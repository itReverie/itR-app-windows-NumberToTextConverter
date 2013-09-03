using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingConverter
{
    public class ConverterTesting
    {

        public static void Main(string[] arguments)
        {
            ///Loads by default the UI if there are no parameters
            if (arguments.Length == 0)
            {
                LoadConverterUI();
            }

            if (arguments.Length > 0)
            {
                switch (arguments[0])
                {
                    case "-Comsole":
                        LoadConsole();
                        break;
                    case "-Testing":
                        RunTestingMethods();
                        break;
                    default:
                        LoadConverterUI();
                        break;

                }
            }
        }

        /// <summary>
        /// Loads the console
        /// </summary>
        private static void RunTestingMethods()
        {
            NumberToText_Performance runStressTesting = new NumberToText_Performance();
            runStressTesting.TestingPerformance();
        }

        /// <summary>
        /// Loads the console
        /// </summary>
        private static void LoadConsole()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConverterUI());
        }

        /// <summary>
        /// Loads the user interface to test the converter
        /// </summary>
        private static void LoadConverterUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConverterUI());
        }
    }
}
