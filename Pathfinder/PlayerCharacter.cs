﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder
{
    enum Attributes
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma
    }

    struct AttributeScores
    {
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;
    }

    public struct Skill
    {
        public string name { get; set; }
        public int bonusAttribute { get; set; }
        public bool trained { get; set; }
    }

    public struct SkillValues
    {
        public string name { get; set; }
        public int bonus { get; set; }
        public int ranks { get; set; }
    }

    class PlayerCharacter
    {
        #region Variables

        public List<SkillValues> skills { get; set; }
        public int level { get; set; }

        public string name;
        public CharacterClass playerClass;
        public Control classControl;
        public CharacterRace race;
        public AttributeScores attributeStats;
        //int[] attributeStats;
        public int maxHP;
        public int currentHP;
        public int nonLethalDamage; //need to incorporate
        public int armorClass;
        public int flatFootedArmorClass;
        public int touchArmorClass;
        public int initiative;
        public int fortitudeSave;
        public int willSave;
        public int reflexSave;
        public int baseAttackBonus;
        public int cmb;
        public int cmd;

        private XDocument characterInfoXML;

        #endregion Variables

        #region Constructors

        public PlayerCharacter()
        {
            skills = new List<SkillValues>();

        }

        PlayerCharacter(CharacterClass _playerClass, CharacterRace _race)
        {
            
        }

        PlayerCharacter(CharacterClass _playerClass, CharacterRace _race, AttributeScores _attributeStats, List<SkillValues> _skills,
                        int _maxHP, int _currentHP, int _armorClass, int _flatFootedArmorClass, int _TouchArmorClass, int _initiative,
                        int _fortitudeSave, int _willSave, int _reflexSave, int _baseAttackBonus, int _cmb, int _cmd)
        {
            playerClass = _playerClass;
            race = _race;
            attributeStats = _attributeStats;
            skills = _skills;
            maxHP = _maxHP;
            currentHP = _currentHP;
            armorClass = _armorClass;
            flatFootedArmorClass = _flatFootedArmorClass;
            touchArmorClass = _TouchArmorClass;
            initiative = _initiative;
            fortitudeSave = _fortitudeSave;
            willSave = _willSave;
            reflexSave = _reflexSave;
            baseAttackBonus = _baseAttackBonus;
            cmb = _cmb;
            cmd = _cmd;
        }

        #endregion Constructors

        #region Functions

        #region XML

        /// <summary>
        /// Reads character information along with all class and race information from an xml file
        /// Sends each individual class/race it's own XElement to parse
        /// </summary>
        /// <param name="filePath"> XML file where character is saved </param>
        public void OpenCharacterFromXML(string filePathParam)
        {
            characterInfoXML = XDocument.Load(filePathParam);
            XElement xmlTopNode = characterInfoXML.Element("Character");

            //XElement setupOpElement = inspectionTopNode.Element("SetupOperations");
            //foreach (XElement setupOpChildElement in setupOpElement.Elements("Operation"))
            //{
            //    //PrintToGUIMessagesDelegate(" found a setup element <operation>");
            //    addOperation(null, setupOpChildElement, true);
            //}

            XElement generalTopNode = xmlTopNode.Element("General");
            GetGeneralInfoFromXML(generalTopNode);

            // iterate through each 
            foreach (XElement currentClass in xmlTopNode.Elements("Class").Elements<XElement>())
            {
                GetClassFromXML(currentClass);
            }

            foreach (XElement currentRace in xmlTopNode.Elements("Race").Elements<XElement>())
            {
                GetRaceFromXML(currentRace);
            }

            //XElement skillsTopNode = xmlTopNode.Element("Skills");
            GetSkillInfoFromXML(xmlTopNode);
            
            classControl = playerClass.GetClassControl();
            classControl.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="topNode"></param>
        private void GetGeneralInfoFromXML(XElement topNode)
        {
            //character name
            name = topNode.Element("Name").Value.ToString();

            //level
            level = int.Parse(topNode.Element("Level").Value);

            //attributes
            attributeStats.strength = int.Parse(topNode.Element("Strength").Value);
            attributeStats.dexterity = int.Parse(topNode.Element("Dexterity").Value);
            attributeStats.constitution = int.Parse(topNode.Element("Constitution").Value);
            attributeStats.intelligence = int.Parse(topNode.Element("Intelligence").Value);
            attributeStats.wisdom = int.Parse(topNode.Element("Wisdom").Value);
            attributeStats.charisma = int.Parse(topNode.Element("Charisma").Value);

            //max HP
            maxHP = int.Parse(topNode.Element("MaxHP").Value);

            //current HP
            currentHP = int.Parse(topNode.Element("CurrentHP").Value);

            //non-lethal damage
            nonLethalDamage = int.Parse(topNode.Element("NonLethalDamage").Value);

            //armor class
            armorClass = int.Parse(topNode.Element("ArmorClass").Value);

            //flat-footed armor class
            flatFootedArmorClass = int.Parse(topNode.Element("FlatFootedAC").Value);

            //touch armor class
            touchArmorClass = int.Parse(topNode.Element("TouchAC").Value);

            //initiative
            initiative = int.Parse(topNode.Element("Initiative").Value);

            //fortitude save
            fortitudeSave = int.Parse(topNode.Element("FortitudeSave").Value);

            //will save
            willSave = int.Parse(topNode.Element("WillSave").Value);

            //reflex save
            reflexSave = int.Parse(topNode.Element("ReflexSave").Value);

            //base attack bonus
            baseAttackBonus = int.Parse(topNode.Element("BaseAttackBonus").Value);

            //cmb
            cmb = int.Parse(topNode.Element("CMB").Value);

            //cmd
            cmd = int.Parse(topNode.Element("CMD").Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        private void GetClassFromXML(XElement element)
        {
            CharacterClass temp;

            if (element.Name.LocalName.Equals("Kineticist"))
            {
                temp = new Kineticist(element);
            }
            else
            {
                throw new Exception("Could not find class within XML");
            }

            playerClass = temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        private void GetRaceFromXML(XElement element)
        {
            CharacterRace temp;

            if (element.Name.LocalName.Equals("Gnome"))
            {
                temp = new Gnome(element);
            }
            else
            {
                throw new Exception("Could not find race within XML");
            }

            race = temp;
        }

        private void GetSkillInfoFromXML(XElement element)
        {
            SkillValues temp;
            foreach (XElement currentSkill in element.Elements("Skills").Elements<XElement>())
            {
                temp = new SkillValues();
                temp.name = currentSkill.Element("Name").Value;
                temp.bonus = int.Parse(currentSkill.Element("Bonus").Value);
                temp.ranks = int.Parse(currentSkill.Element("Ranks").Value);
                skills.Add(temp);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        public void SaveCharacterToXML(string filepath)
        {
            XDocument saveTree = new XDocument(new XElement("Character"));

            //add general character info
            XElement generalInfoElement = new XElement("General");
            generalInfoElement = SetGeneralXMLInfo(generalInfoElement);
            saveTree.Root.Add(generalInfoElement);

            //add class specific info
            XElement classInfoElement = new XElement("Class");
            classInfoElement = playerClass.SetClassXMLInfo(classInfoElement);
            saveTree.Root.Add(classInfoElement);

            //add race specific info
            XElement raceInfoElement = new XElement("Race");
            raceInfoElement = race.SetRaceXMLInfo(raceInfoElement);
            saveTree.Root.Add(raceInfoElement);

            //add skill info
            XElement skillInfoElement = new XElement("Skills");
            skillInfoElement = SetSkillXMLInfo(skillInfoElement);
            saveTree.Root.Add(skillInfoElement);

            saveTree.Save(filepath);
        }

        /// <summary>
        /// Sets up the "General" section of the XML
        /// fills in all variables
        /// </summary>
        /// <param name="parentElement"></param>
        /// <returns></returns>
        private XElement SetGeneralXMLInfo(XElement parentElement)
        {
            XElement temp;
            temp = new XElement("Name", name);
            parentElement.Add(temp);
            temp = new XElement("Level", level);
            parentElement.Add(temp);
            temp = new XElement("Strength", attributeStats.strength);
            parentElement.Add(temp);
            temp = new XElement("Dexterity", attributeStats.dexterity);
            parentElement.Add(temp);
            temp = new XElement("Constitution", attributeStats.constitution);
            parentElement.Add(temp);
            temp = new XElement("Intelligence", attributeStats.intelligence);
            parentElement.Add(temp);
            temp = new XElement("Wisdom", attributeStats.wisdom);
            parentElement.Add(temp);
            temp = new XElement("Charisma", attributeStats.charisma);
            parentElement.Add(temp);
            temp = new XElement("MaxHP", maxHP);
            parentElement.Add(temp);
            temp = new XElement("CurrentHP", currentHP);
            parentElement.Add(temp);
            temp = new XElement("NonLethalDamage", nonLethalDamage);
            parentElement.Add(temp);
            temp = new XElement("ArmorClass", armorClass);
            parentElement.Add(temp);
            temp = new XElement("FlatFootedAC", flatFootedArmorClass);
            parentElement.Add(temp);
            temp = new XElement("TouchAC", touchArmorClass);
            parentElement.Add(temp);
            temp = new XElement("Initiative", initiative);
            parentElement.Add(temp);
            temp = new XElement("FortitudeSave", fortitudeSave);
            parentElement.Add(temp);
            temp = new XElement("WillSave", willSave);
            parentElement.Add(temp);
            temp = new XElement("ReflexSave", reflexSave);
            parentElement.Add(temp);
            temp = new XElement("BaseAttackBonus", baseAttackBonus);
            parentElement.Add(temp);
            temp = new XElement("CMB", cmb);
            parentElement.Add(temp);
            temp = new XElement("CMD", cmd);
            parentElement.Add(temp);

            return parentElement;
        }
        
        private XElement SetSkillXMLInfo(XElement parentElement)
        {
            XElement temp, tempChild;
            foreach (SkillValues skill in skills)
            {
                temp = new XElement("Skill");
                tempChild = new XElement("Name", skill.name);
                temp.Add(tempChild);
                tempChild = new XElement("Bonus", skill.bonus);
                temp.Add(tempChild);
                tempChild = new XElement("Ranks", skill.ranks);
                temp.Add(tempChild);

                parentElement.Add(temp);
            }

            return parentElement;
        }


        ///// <summary>
        ///// loads a character from an xml file
        ///// </summary>
        ///// <param name="filename"> xml file to be parsed </param>
        //public void LoadCharacterFromXML(string fileName)
        //{
        //    //System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
        //    //XDocument document = new XDocument();
        //    using (XmlReader reader = XmlReader.Create(fileName))
        //    {
        //        while (reader.Read())
        //        {
        //            if(reader.IsStartElement())
        //            {
        //                switch (reader.Name)
        //                {
        //                    case "name":
        //                        if(reader.Read())
        //                            name = reader.Value.Trim();
        //                        break;
        //                    case "playerClass":
        //                        string className = reader["name"];
        //                        if (className != null)
        //                        {
        //                            if (!playerClass.SetClassValuesFromXML(className))
        //                                throw new Exception("Error: Class values could not be loaded from the xml file");
        //                        }
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}

        #endregion XML

        /// <summary>
        /// Gets a list of all skills
        /// </summary>
        /// <returns></returns>
        public List<Skill> GetListOfSkills()
        {
            List<Skill> list = new List<Skill>();
            Skill temp = new Skill();

            temp.name = "Acrobatics";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Appraise";
            temp.bonusAttribute = (int)Attributes.intelligence;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Bluff";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Climb";
            temp.bonusAttribute = (int)Attributes.strength;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Diplomacy";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Disable Device";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Disguise";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Escape Artist";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Fly";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Handle Animal";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Heal";
            temp.bonusAttribute = (int)Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Intimidate";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Linguistics";
            temp.bonusAttribute = (int)Attributes.intelligence;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Perception";
            temp.bonusAttribute = (int)Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Ride";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Sense Motive";
            temp.bonusAttribute = (int)Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Sleight Of Hand";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Spellcraft";
            temp.bonusAttribute = (int)Attributes.intelligence;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Stealth";
            temp.bonusAttribute = (int)Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Survival";
            temp.bonusAttribute = (int)Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Swim";
            temp.bonusAttribute = (int)Attributes.strength;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Use Magical Device";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Concentration";
            temp.bonusAttribute = (int)Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            return list;
        }

        private void AssignDefaultSkillValues()
        {
            List<Skill> skillInfo = GetListOfSkills();
            SkillValues temp;
            foreach (Skill currentSkill in skillInfo)
            {
                temp = new SkillValues();
                temp.name = currentSkill.name;
                temp.bonus = 0;
                temp.ranks = 0;
                skills.Add(temp);
            }
        }
        #endregion Functions
    }
}