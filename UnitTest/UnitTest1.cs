using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OSAGOCalc;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationUnitTest()
        {
            OSAGOCalc.OSAGOCalc k = new OSAGOCalc.OSAGOCalc();
            k.rslt = 0; k.bt = 1.25; k.kt = 0.5; k.kbm = 1.23;
            k.ko = 0.6; k.kvs = 1; k.km = 0.8; k.ks = 1.25;

        }
    }
}
