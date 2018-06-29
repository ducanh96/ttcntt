using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouteEngine
{
    public class Connection
    {
        
        public Location A { get; set; }
        public Location B { get; set; }
        
        public int Weight { get; set; }
        bool selected=false;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Connection(Location a, Location b, int weight)
        {
            this.A = a;
            this.B = b;
            this.Weight = weight;
        }

    }
}
