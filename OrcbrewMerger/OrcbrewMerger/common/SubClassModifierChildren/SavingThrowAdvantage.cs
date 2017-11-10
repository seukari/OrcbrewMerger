using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class SavingThrowAdvantage : SubClassModifier
    {
        public StatusCondition.eStatusType savingThrowAdvantage = StatusCondition.eStatusType.Blinded;

        public SavingThrowAdvantage(StatusCondition.eStatusType advantage)
        {
            savingThrowAdvantage = advantage;
        }        
    }
}
