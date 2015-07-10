using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleIntersection
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleInsideAnother()
        {
            var rectangle = new Rectangle(new Point(0, 10), new Point(10, 0));
            var otherRectangle = new Rectangle(new Point(4,4), new Point(5,3));

            var actual = rectangle.Overlaps(otherRectangle);

            Assert.IsTrue(actual);
        }
    }
}