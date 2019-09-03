using CalculationDLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTool;


namespace TestCalcu
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            
            

        }


        [TestMethod]
        public void TestPlus()
        {

            //Act
            Calculator calc = new Calculator();
            //Arrange
            double results = calc.Add(5, 5);
            double expectedvalue = 10;
            //assert
            Assert.AreEqual(expectedvalue, results, 0.002);
        }


        [TestMethod]
        public void TestMinus()
        {
            Calculator calc = new Calculator();


            double results = calc.Substract(6, 20);
            double expectedResult = results;

            Assert.AreEqual(expectedResult,results,0.002);
        }
    }
}
