using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    public class Team
    {
        private string _name;

        public Team(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Description { get; set; }
        public string Category { get; set; }
    }
}
