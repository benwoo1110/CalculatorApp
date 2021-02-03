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
        // Single operator pair
        [TestCase("1+2", 3)]
        [TestCase("1-2", -1)]
        [TestCase("3x2", 6)]
        [TestCase("4÷2", 2)]
        // Start prefix
        [TestCase("-4+2", -2)]
        [TestCase("+3+2", 5)]
        // White space
        [TestCase("1 + 4", 5)]
        [TestCase("8 ÷ 2", 4)]
        // End dot
        [TestCase("1+4.", 5)]
        [TestCase("8.÷2.", 4)]
        // Consecutive same order type
        [TestCase("4x3÷2", 6)]
        [TestCase("4-2+3", 5)]
        [TestCase("10+4-2+3-1-2", 12)]
        // Simple bracket
        [TestCase("5x(3÷2)", 7.5)]
        [TestCase("4-(2+3)", -1)]
        // Complex
        [TestCase("30-5x(12-((2+2)x(5-3)))", 10)]
        [TestCase("50-((2x(3+1)-((39÷3)-(2+42)x3))+2)x3+1÷2", -336.5)]
        public void Calculate_ValidExpression_ReturnsDouble(string expression, double expectedResult)
        {
            var result = new ExpressionBuilder(expression).Calculate();

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
