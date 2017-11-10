using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class NumberOfAttacks : SubClassModifier
    {
        public enum eNumberOfAttacks { Two, Three, Four };
        public eNumberOfAttacks numberOfAttacks = eNumberOfAttacks.Two;

        public NumberOfAttacks(eNumberOfAttacks number)
        {
            numberOfAttacks = number;
        }        
    }
}
