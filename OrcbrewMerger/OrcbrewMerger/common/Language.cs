using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class Language
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";
        public string description = "";

        public Language(string Key, string Name, string OptionPack, string Description)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
            description = Description;
        }
    }
}
