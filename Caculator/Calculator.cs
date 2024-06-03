using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    internal class Calculator
    {
        public float x;
        public float y;
        public Calculator()
        {
            x = 0;
            y = 0;
        }
        public float Minus(float a, float b)
        {
            return a - b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public float Mutiple(float a, float b)
        {
            return a * b;
        }
        public float Divide(float a, float b)
        {
            return a / b;
        }
    }