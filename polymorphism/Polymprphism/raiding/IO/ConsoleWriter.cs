using raiding.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace raiding.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text) => Console.WriteLine(text);
      
    }
}
