namespace TestingLab.Tests;

[TestClass]
public class MathTests
{
    [TestMethod]
    public void TestAdd()
    {
        Assert.AreEqual(3, BasicMath.Add(1, 2));
    }
    [TestMethod]
    public void TestSubtract()
    {
        Assert.AreEqual(10, BasicMath.Subtract(20, 10));
    }
    [TestMethod]
    public void TestMultiply()
    {
        Assert.AreEqual(25, BasicMath.Multiply(5, 5));
    }
    [TestMethod]
    public void TestDivide()
    {
        Assert.AreEqual(9, BasicMath.Divide(27, 3));
    }

}