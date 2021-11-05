using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    class Vertex
    {
        public int number;
        public int Number
        {
            get
            {
                return number;
            }
            private set { }
        }
        public Vertex(int number)
        {
            this.number = number;
        }
    }
}
