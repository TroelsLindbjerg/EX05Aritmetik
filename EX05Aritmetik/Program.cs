using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05Aritmetik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg5
            //Lommeregner
            
            Console.WriteLine("Velkommen til din lommeregner! ");
            Console.WriteLine("Her kan du pluse, minus, gange og dividere to tal");
            Console.WriteLine("--------------------------------");
            //Mængde tal jeg skal bruge
            double num1, num2;
            Console.Write("Indtast første tal og ENTER: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast andet tal og ENTER: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //Regnestykket
            double resultat1 = num1 + num2;
            double resultat2 = num1 - num2;
            double resultat3 = num1 * num2;
            double resultat4 = num1 / num2;
            double resultat5 = num1 % num2;
            Console.WriteLine($"Resultat ved plus: {num1} + {num2} = {resultat1}");
            Console.WriteLine($"Resultat ved plus: {num1} - {num2} = {resultat2}");
            Console.WriteLine($"Resultat ved plus: {num1} * {num2} = {resultat3}");
            Console.WriteLine($"Resultat ved plus: {num1} / {num2} = {resultat4}");
            Console.WriteLine($"Resultat ved plus: {num1} % {num2} = {resultat5}");

        }
    }
}
