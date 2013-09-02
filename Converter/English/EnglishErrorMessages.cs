using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace ConverterController
{
    public static class EnglishErrorMessages
    {
        /// <summary>
        /// Error in the input value
        /// </summary>
        public static string Error_InvalidInput = "The following input is invalid.";

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_OnlyNumericDigits = "The program only accepts numbers.";

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_IncorrectFormat = "The number is in an incorrect format.";

        /// <summary>
        /// The number is not in a valid range 
        /// </summary>
        public static string Reason_ValueOutOfBoundaries = "The program accepts positive and negative values with 27 positions as integers.";

    }
}
