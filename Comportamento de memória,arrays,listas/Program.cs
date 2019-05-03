using System;
using System.Globalization;

namespace Comportamento_de_memória_arrays_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vect = new Quartos[10];

            Console.Write("Quantos quartos vocês querem alugar? ");
            int n = int.Parse(Console.ReadLine()); 
            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Quartos { Name = name, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i <= 9; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i].Name + ", " + vect[i].Email);
                    
                }
            }

            //Console.WriteLine(vect[2].Name + ", " + vect[2].Email);
        }
    }
}
