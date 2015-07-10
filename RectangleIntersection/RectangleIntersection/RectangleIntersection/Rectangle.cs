namespace RectangleIntersection
{
    public class Rectangle
    {
        Point _leftUpper;
        Point _rightLower;

        public Rectangle(Point leftUpper, Point rightLower)
        {
            _leftUpper = leftUpper;
            _rightLower = rightLower;
        }

        /**
         * Determines if a rectangle overlaps in area with this rectangle
         * */
        public bool Overlaps(Rectangle other)
        {
            return false;
        }
    }
}