using System;

namespace MVCproject
{
    internal class Calculadora
    {

        static void Main(string[] args)
        {
            var controller = new Calcular();
            int resultado = controller.calc();

            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
        }

    }
}
