using NUnit.Framework;

namespace CalculatorApp.UnitTests
{
    public class NodeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double result = new ExpressionBuilder("30-5x(12-((2+2)x(5-3)))").Calculate();
            
            Assert.That(result, Is.EqualTo(10));
        }
    }
}
