using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Pathfinder
{
    public abstract class CharacterRace
    {
        #region Variables

        public string raceName { get; set; }
        private int[] statBonus;

        #endregion Variables

        #region Constructors

        CharacterRace()
        {

        }

        CharacterRace(string _raceName, int[] _statBonus)
        {
            raceName = _raceName;
            statBonus = _statBonus;
        }

        #endregion Constructors
    }
}

