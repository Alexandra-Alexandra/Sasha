using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class Class1 : InterfaceCalc
    {
        public double a = 0;
        public double memory = 0;

        public double b { get; set; }

        public void Clear()
        {
            memory = 0.0;
        }

        public void Clear_a()
        {
            a = 0;
        }

        public double Divide(double b)
        {
            return a / b;
        }

        public double Minus(double b)
        {
            return a - b;
        }

        public double Plus(double b)
        {
            return a + b;
        }

        public void Save(double a)
        {
            this.a = a;
        }

        public double Show()
        {
            return memory;
        }

        public double Umnozhat(double b)
        {
            return a * b;
        }
    }
}
