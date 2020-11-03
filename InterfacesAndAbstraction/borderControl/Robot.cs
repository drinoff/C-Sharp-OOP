using System;
using System.Collections.Generic;
using System.Text;

namespace borderControl 
{
    public class Robot : IIdable
    {
        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; set; }
        public string Id { get => this.Model; set { this.Model = value; } }
    }
}
