﻿using System;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Core.Providers
{
    public class ConsoleReader : IReader
    {
        public virtual string Read()
        {
            return Console.ReadLine();
        }
    }
}