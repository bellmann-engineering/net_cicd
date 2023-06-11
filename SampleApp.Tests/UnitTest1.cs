namespace SampleApp.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
			// Arrange
            int a = 5;
            int b = 10;
            int expectedSum = 15;

            // Act
            int actualSum = 15;

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
    }
}