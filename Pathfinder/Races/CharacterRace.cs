using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pathfinder
{
    public enum Races
    {
        Gnome
    }

    public abstract class CharacterRace
    {
        #region Variables

        public string raceName { get; set; }
        public int[] statBonus { get; set; }
        public int sizeMod { get; set; }

        #endregion Variables

        #region Constructors

        protected CharacterRace()
        {

        }

        CharacterRace(string _raceName, int[] _statBonus)
        {
            raceName = _raceName;
            statBonus = _statBonus;
        }

        #endregion Constructors

        public abstract XElement SetRaceXMLInfo(XElement parentElement);
    }
}

