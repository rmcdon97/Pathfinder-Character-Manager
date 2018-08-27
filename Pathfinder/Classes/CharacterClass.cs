using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Pathfinder
{
    public enum Classes
    {
        Kineticist
    }

    public struct ClassAttributeInfo
    {
        public string variableName { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }

    public abstract class CharacterClass
    {
        #region Variables

        public string className { get; set; }
        int[] attributePriority; //lower value = highest priority
        public int hitDie;
        string classSkills; //comma-separated list of class skills (copy-paste from website)

        #endregion Variables

        #region Constructors

        protected CharacterClass()
        {

        }

        CharacterClass(string _className, int[] _attributePriority, int _hitDie)
        {
            className = _className;
            attributePriority = _attributePriority;
            hitDie = _hitDie;
        }

        #endregion Constructors

        #region Functions

        public bool SetClassValuesFromXML(string classType)
        {
            return true; 
        }

        public abstract XElement SetClassXMLInfo(XElement parentElement);

        public abstract List<ClassAttributeInfo> GetClassAttributeInfo();

        public abstract Control GetClassControl();

        #endregion Functions
    }
}

