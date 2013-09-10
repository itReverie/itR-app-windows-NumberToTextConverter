using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Converter;

namespace Converter
{
    /// <summary>
    /// Derived class from NumberBase to convert decimal numbers to English text
    /// </summary>
    class NumberEnglish : NumberBase
    {
        /// <summary>
        /// Constructor to load English resources.
        /// </summary>
        /// <param name="culture">Culture Information</param>
        public NumberEnglish(CultureInfo culture)
        {
            NumbersDictionary.LoadNumbers(culture);
            ErrorMessagesDictionary.LoadErrorsText(culture);
        }

    }
}
