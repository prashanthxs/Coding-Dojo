using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangleA = new Rectangle(new Point(), new Point());
            var rectangleB = new Rectangle(new Point(), new Point());
        }
    }

    public interface IShape
    {
        public bool Overlaps(IShape other);
    }

    public class Rectangle : IShape
    {
        Point _leftUpper;
        Point _rightLower;

        Rectangle(Point leftUpper, Point rightLower)
        {
            _leftUpper = leftUpper;
            _rightLower = rightLower;
        }

        public bool Overlaps(Rectangle other)
        {

        }
    }

    public struct Point
    {
        float x;
        float y;
    }
}
