namespace TalentManagementApi.Test
{
    [TestClass]
    public class CommonUnitTest
    {
        [TestMethod]
        public void TestStringEquals_DescNormalCase_Returns_True()
        {
            // Arrange
            var orderType = "desc";

            // Act
            bool isEquals = string.Equals(orderType, "desc", StringComparison.OrdinalIgnoreCase);

            // Assert
            Assert.IsTrue(isEquals);
        }

        [TestMethod]
        public void TestStringEquals_DescTitleCase_Returns_True()
        {
            // Arrange
            var orderType = "Desc";

            // Act
            bool isEquals = string.Equals(orderType, "desc", StringComparison.OrdinalIgnoreCase);

            // Assert
            Assert.IsTrue(isEquals);
        }

        [TestMethod]
        public void TestStringEquals_DescUpperCase_Returns_True()
        {
            // Arrange
            var orderType = "DESC";

            // Act
            bool isEquals = string.Equals(orderType, "desc", StringComparison.OrdinalIgnoreCase);

            // Assert
            Assert.IsTrue(isEquals);
        }
    }
}