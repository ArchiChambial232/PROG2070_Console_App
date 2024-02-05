using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_Console_App
{
    public class Rectangle
    {
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

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int newLength)
        {
            length = newLength;
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int newWidth)
        {
            width = newWidth;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
