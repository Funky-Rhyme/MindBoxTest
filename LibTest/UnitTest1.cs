using MindBoxTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTriangleRight()
        {
            var triangle = new Triangle(6, 8, 10);

            Assert.IsTrue(triangle.IsRight);
        }

        [TestMethod]
        public void TriangleNotRight()
        {
            var triangle = new Triangle(4, 5, 6);

            Assert.IsFalse(triangle.IsRight);
        }

        [TestMethod]
        public void TriangleAreaIs_6()
        {
            var triangle = new Triangle(3, 4, 5);

            double expected = 6;
            Assert.AreEqual(triangle.Area, expected);
        }

        [TestMethod]
        public void TriangleAreaIs_24()
        {
            var triangle = new Triangle(5, 10, 12);

            double expected = 24.5F;
            Assert.AreEqual(triangle.Area, expected, 0.1);
        }

        [TestMethod]
        public void CircleAreaIs113()
        {
            var circle = new Circle(6);

            double expected = 113.04F;
            Assert.AreEqual(circle.Area, expected, 0.1);
        }

        [TestMethod]
        public void CircleAreaIs452()
        {
            var circle = new Circle(12);

            double expected = 452.38F;
            Assert.AreEqual(circle.Area, expected, 0.2);
        }

        [TestMethod]
        public void IsTriangleExist()
        {
            try
            {
                var triangle = new Triangle(5, 7, 3);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void IsTriangelNotExist()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(10, 5, 3));
        }
    }
}

