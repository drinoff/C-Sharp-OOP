using System;
using System.Collections.Generic;
using System.Text;

namespace militaryElite
{
    public interface ISoldier
    {
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
