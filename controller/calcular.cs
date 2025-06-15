using System;

namespace MVCproject
{
    public class Calcular
    {
        public int calc()
        {

            calculo calc = new calculo();

            Console.WriteLine("Digite o primeiro número: ");
            calc.firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            calc.secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite 1 para soma");
            Console.WriteLine("Digite 2 para subtração");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");

            calc.Operador = Convert.ToInt32(Console.ReadLine());

            int resultado;

            
           switch (calc.Operador)
            {
                case 1:
                    resultado = calc.firstNumber + calc.secondNumber;
                    break;
                case 2:
                    resultado = calc.firstNumber - calc.secondNumber;
                    break;
                case 3:
                    resultado = calc.firstNumber * calc.secondNumber;
                    break;
                case 4:
                    resultado = calc.firstNumber / calc.secondNumber;
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    return 0; // Retorna 0 se o operador for inválido
            }

            return resultado;
        }
    }
}
