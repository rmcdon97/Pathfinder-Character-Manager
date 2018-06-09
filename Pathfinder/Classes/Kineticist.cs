using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public Kineticist(XElement topNode) : base()
        {
            GetKineticistXMLInfo(topNode);
        }

        void GetKineticistXMLInfo(XElement element)
        {
            currentBurn = int.Parse(element.Element("CurrentBurn").Value);

            maxBurn = int.Parse(element.Element("MaxBurn").Value);
        }

        /// <summary>
        /// Sets up the "Kineticist" section of the XML
        /// fills in all variables
        /// </summary>
        /// <param name="parentElement"></param>
        /// <returns></returns>
        public override XElement SetClassXMLInfo(XElement parentElement)
        {
            XElement nameElement = new XElement("Kineticist");
            XElement temp;
            temp = new XElement("CurrentBurn", currentBurn);
            nameElement.Add(temp);
            temp = new XElement("MaxBurn", maxBurn);
            nameElement.Add(temp);

            parentElement.Add(nameElement);
            return parentElement;
        }
    }
}

