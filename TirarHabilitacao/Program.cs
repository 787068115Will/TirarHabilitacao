using System;

namespace HabilitacaoApp
{
    class Program
{
    static void Main(String[] AssemblyLoadEventArgs)
    {
        int idadeMinima = 18;
        int numerosTentativa = 3;
         
        for (int i = 1; i <= numerosTentativa; i++)
        {
            Console.WriteLine($"Tentativa{i}");
            Console.WriteLine("Digite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            
                if (idade >= idadeMinima)
                {
                    Console.WriteLine("Parabnes!Voce pode tirar a sua habiltaçao.");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpa! voce não atigiu a idade minima para tirar habilitação.");

                    if (i < numerosTentativa)
                    {

                        Console.WriteLine("Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("Voce excedeu o numero de tentativas.");
                    }
                        }

                    }
                }
                    }
                }
            
        
       