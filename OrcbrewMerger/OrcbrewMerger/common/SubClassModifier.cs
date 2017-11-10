using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class SubClassModifier
    {
        public enum eModifierType { ArmorProficiency, DamageImmunity, DamageResistance, FlyingSpeed, NumberOfAttacks, SavingThrowAdvantage, SkillProficiency, Spell, WeaponProficiency };

        public eModifierType modifierType = eModifierType.ArmorProficiency;
        public uint unlockLevel = 0;

        public SubClassModifier modifierContents = new SubClassModifier();        
    }
}
