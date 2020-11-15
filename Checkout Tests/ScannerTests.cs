using NUnit.Framework;

using Zen.Checkout;

namespace Zen.Checkout.Tests
{
    public class Tests
    {
        [Test]
        public void Scanner_ProductA_Scans()
        {
            // Arrange
            Product productA = new Product("productA", 10);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productA);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(10, total);
        }

        [Test]
        public void Scanner_ProductB_Scans()
        {
            // Arrange
            Product productB = new Product("productB", 20);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productB);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(20, total);
        }

        [Test]
        public void Scanner_ProductC_Scans()
        {
            // Arrange
            Product productC = new Product("productC", 30);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productC);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(30, total);
        }

        [Test]
        public void Scanner_ProductAB_Scans()
        {
            // Arrange
            Product productA = new Product("productA", 10);
            Product productB = new Product("productB", 20);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productA);
            scanner.Scan(productB);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(30, total);
        }

        [Test]
        public void Scanner_ProductA_Special()
        {
            // Arrange
            Product productA = new Product("productA", 10);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productA);
            scanner.Scan(productA);
            scanner.Scan(productA);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(25, total);
        }

        [Test]
        public void Scanner_ProductB_Special()
        {
            // Arrange
            Product productB = new Product("productB", 20);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productB);
            scanner.Scan(productB);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(30, total);
        }

        [Test]
        public void Scanner_ProductAB_Special()
        {
            // Arrange
            Product productA = new Product("productA", 10);
            Product productB = new Product("productB", 20);
            Scanner scanner = new Scanner();

            // Act
            scanner.Scan(productA);
            scanner.Scan(productA);
            scanner.Scan(productA);
            scanner.Scan(productB);
            scanner.Scan(productB);

            scanner.Scan(productA);
            scanner.Scan(productB);
            var total = scanner.GetTotal();
            // Assert
            Assert.AreEqual(85, total);
        }
    }
}