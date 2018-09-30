using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatingStack
{
   
        public interface ICalculatingStack
    {
            void Add(int x);

            void Multiply(int x);

            void Divide(int x);

            void Substract(int x);

            void Clear();

            int Current { get; }
        }
    }


