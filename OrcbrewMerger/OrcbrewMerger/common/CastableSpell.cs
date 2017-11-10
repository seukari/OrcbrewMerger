using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class CastableSpell
    {
        public uint unlockLevel = 0;
        public Spell.eSpellLevel spellLevel = Spell.eSpellLevel.Cantrip;
        public Character.eAbility spellcastingAbility = Character.eAbility.Intelligence;
        public Spell spell = new Spell();
    }
}
