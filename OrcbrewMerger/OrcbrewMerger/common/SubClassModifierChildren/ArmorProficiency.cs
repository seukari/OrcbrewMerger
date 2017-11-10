using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class ArmorProficiency : SubClassModifier
    {
        public enum eArmorProficiency { Light, Medium, Heavy, Shield };

        public eArmorProficiency armorProficiency = eArmorProficiency.Light;        

        public ArmorProficiency(eArmorProficiency proficiency)
        {
            armorProficiency = proficiency;
        }        
    }
}
