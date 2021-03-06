﻿using System;
using Engine.Models;

namespace Engine.Actions
{
    class UseOffensiveSkill : BaseSkillAction, IAction
    {
        private readonly Skill _skill;

        public UseOffensiveSkill(Skill skillInUse)
            : base(skillInUse)
        {
            if (skillInUse.MinimumDamage < 0)
            {
                throw new ArgumentException("Minimum damage must be more than 0.");
            }

            if (skillInUse.MaximumDamage < skillInUse.MinimumDamage)
            {
                throw new ArgumentException("maximumDamage must be >= minimumDamage");
            }

            _skill = skillInUse;
        }

        public void Execute(LivingEntity actor, LivingEntity target)
        {
            int damage = RandomNumberGenerator.NumberBetween(_skill.MinimumDamage, _skill.MaximumDamage);

            string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
            string targetName = (target is Player) ? "You" : $"the {target.Name.ToLower()}";

            _skill.AddExperience(actor.Intelligence); //adds skill experience based on intelligence
            
            if (damage == 0)
            {
                ReportResult($"{actorName} missed {targetName}.");
            }
            else
            {
                ReportResult($"{actorName} hit {targetName} for {damage} point{(damage > 1 ? "s" : "")} of damage.");
                target.TakeDamage(damage);
            }
        }
    }
}
