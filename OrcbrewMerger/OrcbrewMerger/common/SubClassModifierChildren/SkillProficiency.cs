using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class SkillProficiency : SubClassModifier
    {
        public Character.eSkill skillProficiency = Character.eSkill.Acrobatics;

        public SkillProficiency(Character.eSkill skill)
        {
            skillProficiency = skill;
        }        
    }
}
