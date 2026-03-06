using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class Ghost
    {

        private string name;
        private int size = 1;
        public Ghost(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Size
        {
            set
            {
                    size = value;
            }
            get
            {
                return size;

            }
        }

        public string Haunt()
        {
            return name + "Spooky sagt: 'Buh'" + size;
        }
    }
}
