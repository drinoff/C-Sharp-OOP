using System;
using System.Collections.Generic;
using System.Text;

namespace foodShortage
{
    public class Robot : IIdable
    {
        private string model;
        private string id;
        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get => this.model; set{this.model = value; } }
        public string Id { get => this.id; set { this.id = value; } }
    }
}
