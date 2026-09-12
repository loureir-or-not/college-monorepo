using CsharpCalculator.Core;

namespace CsharpCalculator.CoreTests;

[TestClass]
public sealed class CalculatorTest
{
    [TestMethod]
    public void TestDivByZero()
    {
        int result = 0;
        int status = Calculator.Calculate(
            [CalculatorOp.Divide],
            [1, 0],
            out result
        );
        Assert.AreEqual(1, status);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestNotEnoughNumbers()
    {
        int result = 0;
        int status = Calculator.Calculate(
            [CalculatorOp.Add, CalculatorOp.Multiply],
            [1, 2],
            out result
        );
        Assert.AreEqual(1, status);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestCalculate()
    {
        int result = 0;
        int status = Calculator.Calculate(
            [CalculatorOp.Add, CalculatorOp.Subtract, CalculatorOp.Multiply, CalculatorOp.Divide, CalculatorOp.Power],
            [32, 16, 8, 4, 2, 1],
            out result
        );
        Assert.AreEqual(0, status);
        Assert.AreEqual(80, result);
    }
}
