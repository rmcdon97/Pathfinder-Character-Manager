using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Pathfinder
{
    public class Kineticist : CharacterClass
    {
        #region Variables

        public int currentBurn { get; set; }
        public int maxBurn { get; set; }

        #endregion Variables

        #region Constructors

        public Kineticist() : base()
        {
            
        }

        public Kineticist(XElement topNode) : base()
        {
            className = "Kineticist";
            hitDie = 8;
            GetKineticistXMLInfo(topNode);
        }

        #endregion Constructors

        #region XML

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

        #endregion XML

        public override List<ClassAttributeInfo> GetClassAttributeInfo()
        {
            List<ClassAttributeInfo> classAttributes = new List<ClassAttributeInfo>();
            ClassAttributeInfo temp = new ClassAttributeInfo();

            temp.variableName = "currentBurn";
            temp.type = "int";
            temp.value = currentBurn.ToString();
            classAttributes.Add(temp);

            temp.variableName = "maxBurn";
            temp.type = "int";
            temp.value = maxBurn.ToString();
            classAttributes.Add(temp);

            return classAttributes;
        }

        public override Control GetClassControl()
        {
            return new KineticistControl();
        }
    }
}

