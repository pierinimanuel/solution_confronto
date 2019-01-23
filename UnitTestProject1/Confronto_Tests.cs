using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Confronto_Tests
    {
        [TestMethod]
        public void TestMax()
        {
            int n1 = 0;
            int n2 = 7;
            int max_aspettato = 7;
            int max_calcolato = confronto_library.Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspettato, max_calcolato);

        }
        

    }
}
