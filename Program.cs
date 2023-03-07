using System.Runtime.Serialization;

namespace Finobonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("FIBONACCI");
            int n1 = 0;
            int n2 = 1;
            int soma = 0;

            for(int i = 1; i < 20; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;

                Console.Write(soma+",");
            }
        }
    }
}