using raiding.Core;
using raiding.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();

        }
    }
}
