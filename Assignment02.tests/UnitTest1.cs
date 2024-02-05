using Assignment02;
using System.Drawing;

namespace Assignment02.tests
{
    public class Tests
    {

        private Rectangle _rectangle { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }


        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(1100, 1100)]
        public void GetLength_Test(int length, int expectedLength)
        {
            Rectangle _dummyRectangle = new Rectangle(length, 1);
            var result = _dummyRectangle.GetLength();
            Assert.AreEqual(expectedLength, result);
        }



        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(1100, 1100)]
        public void GetWidth_Test(int width, int expectedWidth)
        {
            Rectangle _dummyRectangle = new Rectangle(1, width);
            var result = _dummyRectangle.GetWidth();
            Assert.AreEqual(expectedWidth, result);
        }


        [TestCase(5)]
        [TestCase(10)]
        [TestCase(1100)]
        public void SetLength_Test(int newLength)
        {
            _rectangle.SetLength(newLength);
            int result = _rectangle.GetLength();
            Assert.AreEqual(newLength, result);
        }



        [TestCase(5)]
        [TestCase(10)]
        [TestCase(1100)]
        public void SetWidth_Test(int newWidth)
        {
            _rectangle.SetWidth(newWidth);
            int result = _rectangle.GetWidth();
            Assert.AreEqual(newWidth, result);
        }


        [TestCase(5, 10, 30)]
        [TestCase(2, 3, 10)]
        [TestCase(1, 1, 4)]
        public void GetPerimeter_Test(int length, int width, int expectedResult)
        {
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            int result = _rectangle.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(5, 10, 50)]
        [TestCase(2, 5, 10)]
        [TestCase(4, 5, 20)]
        public void GetArea_Test(int length, int width, int expectedResult)
        {
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            int result = _rectangle.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
    }
}