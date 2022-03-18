using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0600_valor_entre_200_e_300
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Determinar se um valor pertence a um intervalo:");
            Console.WriteLine();

            Console.Write("Informe o valor           (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Informe o limite inferior (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Informe o limite superior (y): ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("Observe abaixo e ...");
            Console.WriteLine("       1-) x <  a <  y");
            Console.WriteLine("       2-) x <= a <= y");
            Console.WriteLine("       3-) x <= a <  y");
            Console.WriteLine("       4-) x <  a <= y");
            Console.Write("Informe o tipo de comparação: 1, 2, 3 ou 4: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (c == 1)
            {

                if (a > x && a < y)
                {

                    Console.WriteLine("Valor dentro do intervalo");

                }
                else
                {

                    Console.WriteLine("Valor fora do intervalo");

                }

            }
            else if (c == 2)
            {

                if (a >= x && a <= y)
                {

                    Console.WriteLine("Valor dentro do intervalo");

                }
                else
                {

                    Console.WriteLine("Valor fora do intervalo");

                }

            }
            else if (c == 3)
            {

                if (a >= x && a < y)
                {

                    Console.WriteLine("Valor dentro do intervalo");

                }
                else
                {

                    Console.WriteLine("Valor fora do intervalo");

                }

            }
            else
            {

                if (a > x && a <= y)
                {

                    Console.WriteLine("Valor dentro do intervalo");

                }
                else
                {

                    Console.WriteLine("Valor fora do intervalo");

                }

            }

            Console.ReadLine();


        }
    }
}
