using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathClassUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Add()
        {
            Calculator.MathsClass math = new Calculator.MathsClass();
            double result = math.Add(2, 4);
            Assert.AreEqual(result, 6);
        }
        [TestMethod]
        public void TestMethod2_Substract()
        {
            Calculator.MathsClass math = new Calculator.MathsClass();
            double res = math.Substract(10, 4);
            Assert.AreEqual(res, 6);
        }
        [TestMethod]
        public void TestMethod2_Divide()
        {
            Calculator.MathsClass math = new Calculator.MathsClass();
            double res = math.Divide(8, 4);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void TestMethod4_Multiply()
        {
            Calculator.MathsClass math = new Calculator.MathsClass();
            double res = math.Multiply(4, 5);
            Assert.AreEqual(res, 20);
        }
    }
}
