﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Document
{
    internal class Program
    {
        static void Main()
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            Console.ReadKey();  
        }
    }
}
