using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleIntersection
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleToTheLeft()
        {
            var rectangle = new Rectangle(new Point(6, 6), new Point(7, 5));
            var otherRectangle = new Rectangle(new Point(4,6), new Point(5,5));

            var actual = rectangle.Overlaps(otherRectangle);

            Assert.IsFalse(actual);
        }
    }
}