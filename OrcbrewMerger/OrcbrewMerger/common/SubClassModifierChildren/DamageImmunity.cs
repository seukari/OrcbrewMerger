using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class DamageImmunity : SubClassModifier
    {
        public Damage.eDamageType damageImmunity = Damage.eDamageType.Acid;        

        public DamageImmunity(Damage.eDamageType immunity)
        {
            damageImmunity = immunity;
        }        
    }
}
