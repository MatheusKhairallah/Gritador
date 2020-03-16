using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto=Console.ReadLine();
            string texto2=texto.ToUpper();

            Console.WriteLine(texto2);
        }
    }
}
