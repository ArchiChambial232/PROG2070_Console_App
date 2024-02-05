using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_Console_App
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void GetLength_ShouldReturnDefaultLength()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            int result = rectangle.GetLength();

            // Assert
            Assert.AreEqual(1, result);
        }

       
    }
}
