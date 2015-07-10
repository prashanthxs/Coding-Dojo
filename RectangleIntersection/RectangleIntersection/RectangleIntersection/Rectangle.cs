using System;

namespace RectangleIntersection
{
    public class Rectangle
    {
        Point _leftUpper;
        Point _rightLower;

        public Rectangle(Point leftUpper, Point rightLower)
        {
            if (IsValidRectangleConstructorParameters(leftUpper, rightLower))
            {
                _leftUpper = leftUpper;
                _rightLower = rightLower;
            }
            else
            {
                throw new ArgumentException("Invalid Parameters!");
            }
        }

        /**
         * Determines if a rectangle overlaps in area with this rectangle
         * */
        public bool Overlaps(Rectangle other)
        {
            return false;
        }

        // Assume the validation is tested and works fine
        #region Constructor Parameter Validation
        private static bool IsValidRectangleConstructorParameters(Point leftUpper, Point rightLower)
        {
            if (leftUpper._x > rightLower._x)
                return false;
            if (leftUpper._y < rightLower._y)
                return false;
            return true;
        }
        #endregion
    }
}