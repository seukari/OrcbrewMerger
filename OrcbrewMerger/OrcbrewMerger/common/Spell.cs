using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class Spell
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";
        public string description = "";

        public enum eSpellLevel { Cantrip, First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth };
        public enum eSpellSchool { Abjuration, Conjuration, Divination, Enchantment, Evocation, Illusion, Necromancy, Transmutation};

        public eSpellLevel spellLevel = eSpellLevel.Cantrip;
        public eSpellSchool spellSchool = eSpellSchool.Abjuration;
        public Character.eAbility spellcastingAbility = Character.eAbility.Intelligence;

        public string castingTime = "";
        public string range = "";
        public string duration = "";
        public string componentDescription = "";        

        public bool componentVerbal = false;
        public bool componentSomatic = false;
        public bool componentMaterial = false;

        public bool spellListBard = false;
        public bool spellListCleric = false;
        public bool spellListDruid = false;
        public bool spellListPaladin = false;
        public bool spellListRanger = false;
        public bool spellListSorcerer = false;
        public bool spellListWarlock = false;
        public bool spellListWizard = false;

        public Spell()
        {

        }

        public Spell(string Key, string Name, string OptionPack, string Description)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
            description = Description;
        }        

        public Spell(string Key, string Name, string OptionPack, string Description, string CastingTime, string Range, string Duration, bool Verbal, bool Somatic, bool Material, string ComponentDescription)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
            description = Description;
        }
    }
}
