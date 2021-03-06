﻿using System.Linq;
using System.Collections.Generic;
using Engine.Models;
using Engine.Actions;

namespace Engine.Factories
{
    public static class SkillFactory
    {
        private static readonly List<Skill> _skills = new List<Skill>();

        static SkillFactory()
        {
            //Mana Arrow
            Skill ManaArrow = new Skill(101, Skill.SkillTargetType.Offensive,
                Skill.SkillAttackType.Arcane,
                "Mana Arrow",
                "Shoots an arrow made of pure mana at the enemy. Higher skill levels mean you shoot more missiles," +
                " and that the missiles do more damage.",
                1, 3, 2
                );
            ManaArrow.Action = new UseOffensiveSkill(ManaArrow);

            //Fire Bolt
            Skill FireBolt = new Skill(102, Skill.SkillTargetType.Offensive,
                Skill.SkillAttackType.Fire,
                "Fire Bolt",
                "Shoots a bolt of fire at the enemy. Higher skill levels increase the damage.",
                3, 7, 2
                );
            FireBolt.Action = new UseOffensiveSkill(FireBolt);

            _skills.Add(ManaArrow);
            _skills.Add(FireBolt);
        }

        public static Skill GetSkillByID(int id)
        {
            return _skills.FirstOrDefault(x => x.ID == id);
        }
    }
}
