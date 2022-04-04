using System;
using System.Collections.Generic;
using System.Text;

namespace NM_PE15
{
    class Thief : Class
    {
        public Thief(int health, int dmg, int armour, string name)
        {
            this.health = health = 15;
            this.dmg = 10;
            this.armour = 5;
            this.name = name;
        }
    }
}
