using System;
using Entities;
namespace _03___MANUAL___Class {
    class Program {
        static void Main(string[] args) {

            Calculator calculatorA = new Calculator();
            Console.Write("Digite o valor do LADO A: "); calculatorA.X = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do LADO B: "); calculatorA.Y = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do LADO C: "); calculatorA.Z = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.WriteLine(calculatorA);
            Console.WriteLine("");
            Console.WriteLine("");
            Calculator calculatorB = new Calculator();
            Console.Write("Digite o valor do LADO A: "); calculatorB.X = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do LADO B: "); calculatorB.Y = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do LADO C: "); calculatorB.Z = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.WriteLine(calculatorB);
            Console.WriteLine("");
            Console.WriteLine("------------------");

            if (calculatorA.Area() > calculatorB.Area()) {
                Console.WriteLine("O triangulo 1 tem MAIOR AREA.");
            }
            else {
                Console.WriteLine("O triangulo 2 tem MAIOR AREA.");
            }

            

        }
    }
}
