using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double X { get; set; }
        public double Y  { get; set; }
        public double Z { get; set; }

        public Calculator() {
        }      
        public Calculator(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }
        public double HeronP() {
            return (X + Y + Z) * 0.5;
        }
        public double Area() {
            return Math.Sqrt(HeronP() * (HeronP() - X) * (HeronP() - Y) * (HeronP() - Z));
        }

        public override string ToString() {
            return "Valor de P: " + HeronP() + "\nValor da AREA: " + Area().ToString("F2");
        }
    }
}
