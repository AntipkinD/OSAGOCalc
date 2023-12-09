using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OSAGOCalc;
using System.Windows.Forms;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationUnitTest()
        {
            OSAGOCalc.OSAGOCalc k = new OSAGOCalc.OSAGOCalc();
            TextBox rslt = new TextBox();
            rslt.Text = "test"; k.bt = 1.25; k.kt = 0.5; k.kbm = 1.23;
            k.ko = 0.6; k.kvs = 1; k.km = 0.8; k.ks = 1.25;
            OSAGOCalc.OSAGOCalc.GetResult(k.bt, k.kt, k.kbm, k.ko, k.kvs, k.km, k.ks, rslt);
            Console.WriteLine(rslt.Text);

            TextBox actualrslt = new TextBox();
            actualrslt.Text = $"{k.bt * k.kt * k.kbm * k.ko * k.kvs * k.km * k.ks}";

            Assert.AreEqual(rslt.Text, actualrslt.Text);
        }
    }
}
