using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class ModifierSpell : SubClassModifier
    {
        public CastableSpell modifierSpell = new CastableSpell();

        public ModifierSpell(CastableSpell spell)
        {
            modifierSpell = spell;
        }        
    }
}
