using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
  

    public class Rectangle
    {
        // Private attributes
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int initialLength, int initialWidth)
        {
            length = initialLength;
            width = initialWidth;
        }

        // Getter for length
        public int GetLength()
        {
            return length;
        }

        // Setter for length
        public void SetLength(int newLength)
        {
            length = newLength;
        }

        // Getter for width
        public int GetWidth()
        {
            return width;
        }

        // Setter for width
        public void SetWidth(int newWidth)
        {
            width = newWidth;
        }

        // Method to calculate and return perimeter
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        // Method to calculate and return area
        public int GetArea()
        {
            return length * width;
        }
    }

}
