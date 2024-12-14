using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[] semana = new string[7];
                
                semana[0] = "Domingo";
                semana[1] = "Segunda";
                semana[2] = "Terça";
                semana[3] = "Quarta";
                semana[4] = "Quinta";
                semana[5] = "Sexta";
                semana[6] = "Sabado";

                Console.WriteLine(semana[3]); // manual do dia 
                
                Console.WriteLine();
                foreach (string dia in semana) {
                    Console.WriteLine(dia);
                } 

            }
        }
    }
}