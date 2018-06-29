using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouteEngine
{
    public class Location
    {

        public string Identifier{ get; set;}
        public Location()
        {

        }

        public override string ToString()
        {
            return Identifier;
        }
    }
}
