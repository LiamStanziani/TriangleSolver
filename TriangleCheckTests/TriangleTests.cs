using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleCheckTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void triangle_input1_verifyEquilateral()
        {
            //Arrange
            int firstSideInput = 1;
            int secondSideInput = 1;
            int thirdSideInput = 1;
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
