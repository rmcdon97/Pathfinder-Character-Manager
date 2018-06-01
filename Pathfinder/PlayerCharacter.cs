using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;
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

    }

    class PlayerCharacter
    {
        #region Variables

        CharacterClass playerClass;
        CharacterRace race;
        AttributeScores attributeStats;
        int maxHP;
        int currentHP;
        int armorClass;
        int initiative;
        int fortitudeSave;
        int willSave;
        int reflexSave;
        int baseAttackBonus;
        int cmb;
        int cmd;

        #endregion Variables

        #region Constructors

        PlayerCharacter(CharacterClass _playerClass, CharacterRace _race, Attributes _attributeStats,
                        int _maxHP, int _currentHP, int _armorClass, int _initiative, int _fortitudeSave,
                        int _willSave, int _reflexSave, int _baseAttackBonus, int _cmb, int _cmd)
        {
            playerClass = _playerClass;
            race = _race;
            attributeStats = _attributeStats;
            maxHP = _maxHP;
            currentHP = _currentHP;
            armorClass = _armorClass;
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

        /// <summary>
        /// Gets a list of all skills
        /// </summary>
        /// <returns></returns>
        public List<Skill> GetListOfSkills()
        {
            List<Skill> list = new List<Skill>();
            Skill temp = new Skill();

            temp.name = "Acrobatics";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Appraise";
            temp.bonusAttribute = Attributes.intelligence;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Bluff";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Climb";
            temp.bonusAttribute = Attributes.strength;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Diplomacy";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Disable Device";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Disguise";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Escape Artist";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Fly";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Handle Animal";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Heal";
            temp.bonusAttribute = Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Intimidate";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Linguistics";
            temp.bonusAttribute = Attributes.intelligence;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Perception";
            temp.bonusAttribute = Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Ride";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Sense Motive";
            temp.bonusAttribute = Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Sleight Of Hand";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Spellcraft";
            temp.bonusAttribute = Attributes.intelligence;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Stealth";
            temp.bonusAttribute = Attributes.dexterity;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Survival";
            temp.bonusAttribute = Attributes.wisdom;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Swim";
            temp.bonusAttribute = Attributes.strength;
            temp.trained = false;
            list.Add(temp);

            temp.name = "Use Magical Device";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = true;
            list.Add(temp);

            temp.name = "Concentration";
            temp.bonusAttribute = Attributes.charisma;
            temp.trained = false;
            list.Add(temp);

            return list;
        }

        #endregion Functions
    }
}