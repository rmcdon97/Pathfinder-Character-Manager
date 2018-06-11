using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Pathfinder
{
    public class Gnome : CharacterRace
    {
        #region Variables


        #endregion Variables

        #region Constructors

        Gnome() : base()
        {

        }

        Gnome(string _raceName, int[] _statBonus)
        {
            raceName = _raceName;
            statBonus = _statBonus;
        }

        #endregion Constructors
    }
}