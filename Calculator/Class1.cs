﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Math class with Add, Subtract, Multiply and Divide Function
    public class MathsClass
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
