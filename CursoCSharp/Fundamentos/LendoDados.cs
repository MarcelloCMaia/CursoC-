﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar() 
        {
            Console.Write("Qual e o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual e a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual e o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); 

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
