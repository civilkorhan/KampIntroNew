﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DataBaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("DataBase Logg");
        }
    }
}