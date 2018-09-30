using System;
using System.Collections.Generic;
using System.Text;
using CalculatingStack;
using Xunit;


namespace CalculatingStack.CalculatingStackTests
{
    public class CalculatingStackTest
    {

        [Fact]

        public void TestSubstract()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(4);
            calc.Substract(3);
            Assert.Equal(1, calc.Current);
        }

        [Fact]
        public void TestClear()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(51);
            calc.Clear();
            Assert.Equal(0, calc.Current);
        }

        [Fact]
        public void TestAdd()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(5);
            Assert.Equal(5, calc.Current);
        }

        [Fact]
        public void TestMultiply()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(2);
            calc.Multiply(3);
            Assert.Equal(6, calc.Current);
        }

        [Fact]

        public void TestDivide()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(8);
            calc.Divide(4);
            Assert.Equal(2, calc.Current);
        }


        [Fact]
        public void TestDivideException()
        {
            ICalculatingStack calc = new CalculatingStack();
            Assert.Equal(0, calc.Current);
            calc.Add(4);
            Assert.Throws<ArgumentException>(() => calc.Divide(0));
        }

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(7, 1, 8)]
        [InlineData(5, -11, -6)]
        [InlineData(7, -13, -6)]
        public void AddTest3(int x, int y, int res)
        {
            ICalculatingStack calc = new CalculatingStack();
            calc.Add(x);
            calc.Add(y);
            Assert.Equal(calc.Current, res);
        }

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(8, 4, 2)]
        [InlineData(10, 5, 2)]
        public void DivideTest3(int x, int y, int res)
        {
            ICalculatingStack calc = new CalculatingStack();
            calc.Add(x);
            calc.Divide(y);
            Assert.Equal(calc.Current, res);
        }

        [Theory]
        [InlineData(7, 3, 21)]
        [InlineData(3, 2, 7)]
        [InlineData(10, 5, 50)]
        public void MultiplyTest3(int x, int y, int res)
        {
            ICalculatingStack calc = new CalculatingStack();
            calc.Add(x);
            calc.Multiply(y);
            Assert.Equal(calc.Current, res);
        }

        [Theory]
        [InlineData(5, 1, 4)]
        [InlineData(42, 3, 38)]
        [InlineData(10, 5, 5)]
        public void SubstractTest3(int x, int y, int res)
        {
            ICalculatingStack calc = new CalculatingStack();
            calc.Add(x);
            calc.Substract(y);
            Assert.Equal(calc.Current, res);
        }

       
    }
}