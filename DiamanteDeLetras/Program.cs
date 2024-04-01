using System.Security.Cryptography;

namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char primeiraletra = 'A';
            char letraescolida = ColetarLetra();
            int mg1 = 1;
            int margem = letraescolida - primeiraletra;
            int meio = 1;
            TopoEMeio(primeiraletra, letraescolida, ref margem, ref meio);
            meio -= 4;
            ParteDEBaixoDoDiamante(primeiraletra, letraescolida, ref mg1, ref meio);

            Console.ReadLine();
        }

        private static void ParteDEBaixoDoDiamante(char primeiraletra, char letraescolida, ref int mg1, ref int meio)
        {
            for (int i2 = letraescolida - 1; i2 >= primeiraletra; i2--)
            {
                for (int mg = mg1; mg > 0; mg--)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar(i2));
                for (int j2 = 0; j2 < meio; j2++)
                {
                    Console.Write(" ");
                }
                if (i2 != primeiraletra)
                {
                    Console.Write(Convert.ToChar(i2));
                }
                Console.WriteLine();
                mg1++;
                meio -= 2;
            }
        }

        private static void TopoEMeio(char primeiraletra, char letraescolida, ref int margem, ref int meio)
        {
            for (int i = Convert.ToInt32(primeiraletra); i <= letraescolida; i++)
            {
                for (int mg = margem; mg > 0; mg--)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar(i));
                if (i != 65)
                {
                    for (int j = 0; j < meio; j++)
                    {
                        Console.Write(" ");

                    }
                    meio += 2;
                    Console.Write(Convert.ToChar(i));
                }
                Console.WriteLine();

                margem--;

            }
        }

        private static char ColetarLetra()
        {
            Console.WriteLine("Digite a letra desejada EM MAIÚSCULO");
            char letraescolida = Convert.ToChar(Console.ReadLine());
            return letraescolida;
        }
    }
        






    }


