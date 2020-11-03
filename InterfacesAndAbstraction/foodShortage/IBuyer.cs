using System;
using System.Collections.Generic;
using System.Text;

namespace foodShortage
{
    interface IBuyer
    {
        int Food { get; set; }

        void BuyFood();
    }
}
