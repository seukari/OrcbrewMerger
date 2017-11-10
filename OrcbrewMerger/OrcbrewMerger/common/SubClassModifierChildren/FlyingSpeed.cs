using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class FlyingSpeed : SubClassModifier
    {
        public enum eFlyingSpeed { Thirty, Sixty };
        public eFlyingSpeed flyingSpeed = eFlyingSpeed.Thirty;

        public FlyingSpeed(eFlyingSpeed speed)
        {
            flyingSpeed = speed;
        }        
    }
}
