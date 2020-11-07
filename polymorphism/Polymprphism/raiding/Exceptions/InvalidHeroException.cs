using System;
using System.Collections.Generic;
using System.Text;

namespace raiding.Core
{
    public class InvalidHeroException : Exception
    {
        public InvalidHeroException(string msg)
            :base(msg)
        {

        }
    }
}
