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

        [Test]
        public void triangle_input3and3and4_verifyIsosceles()
        {
            //Arrange
            int firstSideInput = 3;
            int secondSideInput = 3;
            int thirdSideInput = 4;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input15and7and15_verifyIsosceles()
        {
            //Arrange
            int firstSideInput = 15;
            int secondSideInput = 7;
            int thirdSideInput = 15;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input30and30and25_verifyIsosceles()
        {
            //Arrange
            int firstSideInput = 25;
            int secondSideInput = 30;
            int thirdSideInput = 30;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input1and10and7_verifyScalene()
        {
            //Arrange
            int firstSideInput = 6;
            int secondSideInput = 10;
            int thirdSideInput = 7;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input34and25and15_verifyScalene()
        {
            //Arrange
            int firstSideInput = 34;
            int secondSideInput = 25;
            int thirdSideInput = 15;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input11and15and23_verifyScalene()
        {
            //Arrange
            int firstSideInput = 11;
            int secondSideInput = 15;
            int thirdSideInput = 23;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input20and18and30_verifyScalene()
        {
            //Arrange
            int firstSideInput = 20;
            int secondSideInput = 18;
            int thirdSideInput = 30;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_input3and9and11_verifyScalene()
        {
            //Arrange
            int firstSideInput = 3;
            int secondSideInput = 9;
            int thirdSideInput = 11;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSideInput, secondSideInput, thirdSideInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
