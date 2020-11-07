using raiding.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace raiding.Models
{
    public class ConsoleReader : IReader
    {
        public string Read() => Console.ReadLine();
        
    }
}
