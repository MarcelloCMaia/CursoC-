﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar() 
        {
            var saudacao = "ola".ToUpper().Insert(3, " World!")
                .Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}