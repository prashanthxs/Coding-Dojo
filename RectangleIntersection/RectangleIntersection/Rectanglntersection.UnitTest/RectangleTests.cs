using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleIntersection
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void SampleTest()
        {
            var rectangle = new Rectangle(new Point(0, 5), new Point(5, 0));
        }
    }
}