using System;
using System.Collections.Generic;
using System.Text;

namespace militaryElite
{
    public interface ILieutenantGeneral
    {
        ICollection<Private> Privates { get; }
    }
}
