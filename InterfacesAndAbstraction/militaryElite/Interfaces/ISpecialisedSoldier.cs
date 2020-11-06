using System;
using System.Collections.Generic;
using System.Text;

namespace militaryElite
{
    public enum Corps
    {
        Airforces,
        Marines
    }
    public interface ISpecialisedSoldier
    {
        Corps Corps { get; }
    }
}
