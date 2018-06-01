using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Pathfinder
{
    public class Kineticist : CharacterClass
    {
        #region Variables

        public int currentBurn { get; set; }
        public int maxBurn { get; set; }
        
        #endregion Variables

        public Kineticist() : base()
        {
            
        }
    }
}

