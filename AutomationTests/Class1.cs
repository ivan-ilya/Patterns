using NUnit.Framework;

namespace AutomationTests;

public class Class1
{
    [Test]
    public void AdditionTest()
    {
        Assert.That(2 + 2, Is.EqualTo(4));
    }
}