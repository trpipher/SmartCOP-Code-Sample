using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCOP_Code_Sample
{
    class Soda : Drink
    {
        public override string Description
        {
            get
            {
                return _name + (_carbonated ? ", carbonated." : ", not carbonated.");
            }
        }
        
        public Soda(string Name, bool Carbonated) : base(Name, Carbonated)
        { }
        
    }
}
