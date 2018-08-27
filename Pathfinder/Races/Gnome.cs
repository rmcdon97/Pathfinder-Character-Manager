using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pathfinder
{
    public class Gnome : CharacterRace
    {
        #region Variables


        #endregion Variables

        #region Constructors

        Gnome() : base()
        {
            raceName = "Gnome";
            sizeMod = 1;
        }

        public Gnome(XElement topNode) : base()
        {
            raceName = "Gnome";
            sizeMod = 1;
            //GetGnomeXMLInfo(topNode);
        }

        Gnome(string _raceName, int[] _statBonus, int _sizeMod)
        {
            raceName = _raceName;
            statBonus = _statBonus;
            sizeMod = _sizeMod;
        }

        #endregion Constructors

        #region XML

        public override XElement SetRaceXMLInfo(XElement parentElement)
        {
            XElement nameElement = new XElement("Gnome");

            parentElement.Add(nameElement);
            return parentElement;
        }

        #endregion XML

    }
}