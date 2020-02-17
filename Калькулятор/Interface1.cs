using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Калькулятор
    {
        interface InterfaceCalc
        {
            void Save(double a);
           void Clear_a();
            double b { get; set; }
            double Minus(double b);
            double Plus(double b);
            double Umnozhat(double b);
            double Divide(double b);
            double Show();
            void Clear();
        }
    }


