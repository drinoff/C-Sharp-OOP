using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.Core.Contracts;
using wildFarm.IO;
using wildFarm.Models.Animals;

namespace wildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private List<Animal> animals;

        public void Run()
        {
            
        }
    }
}
