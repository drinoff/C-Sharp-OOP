using System;
using System.Collections.Generic;
using System.Text;

namespace militaryElite
{
    public interface ICommando
    {
        ICollection<Mission> Missions { get; }
    }
}
