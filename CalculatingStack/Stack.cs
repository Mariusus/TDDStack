using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatingStack
{
    public class Stack
    {


        [Fact]
        public void TestStackAdd() {
            ICalculatingStack calc = new CalculatingStack();
            Stack<int> bigStack = new Stack<int>();
            bigStack.Push(4);
            bigStack.Push(2);
            bigStack.Push(5);
            int x = bigStack.Pop();
            int y = bigStack.Pop() & bigStack.Pop();
            calc.Add(x);
            calc.Add(y);
            Assert.Equal(7, x+y);

        }

    }
}
