using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class PyramidTests
    {
        [TestMethod()]
        [DataRow(4, 6, 8, 64)]
        [DataRow(10, 12, 14, 560)]
        [DataRow(-20, 23, 14, 0)]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateVolumeTest(double baseLength, double baseWidth, double height, double expectedVolume)
        {
            // Arrange
            Pyramid pyramid = new Pyramid(baseLength, baseWidth, height);

            // Act
            double actualVolume = pyramid.CalculateVolume();

            // Assert
            Assert.AreEqual(expectedVolume, actualVolume);
        }
    }
}