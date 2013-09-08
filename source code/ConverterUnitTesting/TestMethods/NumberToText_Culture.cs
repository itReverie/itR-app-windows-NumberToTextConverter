using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace ConverterUnitTesting.TestMethods
{
    /// <summary>
    /// Test Class for the integer values on the converter program
    /// </summary>
    [TestClass]
    public class NumberToText_Culture
    {
        #region TestContextRegion
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        #endregion

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestData\\SpanishData.xml",
            "CultureInputs",
            DataAccessMethod.Sequential)]
        public void CultureSpanish()
        {
            try
            {
                string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
                string numberOutput = Convert.ToString(TestContext.DataRow["Text"]);
                NumberTester numberClass = new NumberTester();
                string actual_value = numberClass.ToText(numberInput,new CultureInfo("es-MX"));
                Assert.AreEqual(numberOutput, actual_value);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
