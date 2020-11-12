using wildFarm.IO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace wildFarm.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text) => Console.WriteLine(text);
      
    }
}
