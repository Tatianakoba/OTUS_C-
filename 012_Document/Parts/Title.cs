﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Document
{
    internal class Title
    {
        string content;
        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
