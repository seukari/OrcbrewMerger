using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class SubClass
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";

        public Class primaryClass = new Class();        

        public List<Feat> feats = new List<Feat>();

        public List<SubClassModifier> modifiers = new List<SubClassModifier>();

    }
}
