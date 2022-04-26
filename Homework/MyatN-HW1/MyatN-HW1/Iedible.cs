using System;
using System.Collections.Generic;
using System.Text;

namespace MyatN_HW1
{
    interface Iedible
    {
        public void Bite()
        { }
        public bool IsConsumed()
        {
            return true;
        }
    }
}
