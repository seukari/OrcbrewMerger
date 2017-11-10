using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class DamageResistance : SubClassModifier
    { 
        public Damage.eDamageType damageResistance = Damage.eDamageType.Acid;        

        public DamageResistance(Damage.eDamageType resistance)
        {
            damageResistance = resistance;
        }        
    }
}
