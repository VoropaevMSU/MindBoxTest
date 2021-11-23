using System;
using System.Collections.Generic;
using TestMindBox;
using TestMindBox.Figures;
using Xunit;

namespace Tests
{
    public class FiguresTests
    {
        [Fact]
        public void IsCalculateCircleAreaRight()
        {
            // Arrange
            Circle circle = Circle.Create(3);
            
            // Act 
            double result = circle.CalculateArea();
            
            // Assert
            Assert.Equal(28.274333882308138, result);
        }

        [Fact]
        public void NegativeCircleRadius()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => Circle.Create(-10));
        }
        
        [Fact]
        public void NegativeTriangleSideA()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => Triangle.Create(-10, 5, 6));
        }
        
        [Fact]
        public void NegativeTriangleSideB()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => Triangle.Create(10, -5, 6));
        }
        
        [Fact]
        public void NegativeTriangleSideC()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => Triangle.Create(10, 5, -6));
        }
        
        
        [Fact]
        public void IsCalculateTriangleAreaRight()
        {
            // Arrange
            Triangle triangle = Triangle.Create(3, 4, 5);
            // Act 
            double result = triangle.CalculateArea();
            
            // Assert
            Assert.Equal(6, result);
        }
        
        
        [Fact]
        public void TriangleIsRectungularTrue()
        {
            // Arrange
            Triangle triangle = Triangle.Create(3, 4, 5);
            
            // Act 
            bool result = triangle.IsRectangular();
            
            // Assert
            Assert.True(result);
        }
        
        
        [Fact]
        public void TriangleIsRectungularFalse()
        {
            // Arrange
            Triangle triangle = Triangle.Create(2, 4, 5);
            
            // Act 
            bool result = triangle.IsRectangular();
            
            // Assert
            Assert.False(result);
        }
    }
}