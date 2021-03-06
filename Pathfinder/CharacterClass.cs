﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder
{
    public abstract class CharacterClass
    {
        #region Variables

        public string className { get; set; }
        int[] attributePriority; //lower value = highest priority
        int hitDie;
        string classSkills; //comma-separated list of class skills (copy-paste from website)

        #endregion Variables

        #region Constructors

        CharacterClass(string _className, int[] _attributePriority, int _hitDie)
        {
            className = _className;
            attributePriority = _attributePriority;
            hitDie = _hitDie;
        }

        #endregion Constructors

    }
}

