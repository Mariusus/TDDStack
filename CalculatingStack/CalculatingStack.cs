using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using CalculatingStack;

namespace CalculatingStack
{
    public class CalculatingStack : ICalculatingStack
    {
        int a;

        public CalculatingStack()
        {
        }

        public int Current { get { return a; } }

        public void Add(int x)
        {
            a += x;
        }

        public void Clear()
        {
            a = 0;

        }

     

        public void Divide(int x)
        {
            if (x == 0)
                throw new ArgumentException("Cannot divide by zero");
            a /= x;
        }

        

        public void Multiply(int x)
        {
            a *= x;
        }


        public void Substract(int x)
        {
            a -= x;
        }
    }
}
