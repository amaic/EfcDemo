using efDemoLib;

namespace efDemoLibTests;

[TestClass]
public class Class1Test
{
    [TestMethod]
    public void TestMethod1()
    {
        var instance1 = new Class1();

        Assert.AreEqual(nameof(Class1), instance1.GetValue());
    }
}