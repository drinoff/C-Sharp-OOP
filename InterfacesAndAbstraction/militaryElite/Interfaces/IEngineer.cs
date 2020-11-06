using System;
using System.Collections.Generic;
using System.Text;

namespace militaryElite
{
    public interface IEngineer
    {
        ICollection<Repair> Repairs { get; }
    }
}
