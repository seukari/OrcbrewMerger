using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrcbrewMerger.common;

namespace OrcbrewMerger.common
{
    public class Feat
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";
        public string description = "";

        public enum ePrerequisites { Spellcasting, Strength13, Constitution13, Dexterity13, Intelligence13, Wisdom13, Charisma13, LightArmorProficiency, MediumArmorProficiency, HeavyArmorProficiency };
        public enum eToolSkillProficiencyGain { Gain0, Gain1, Gain2, Gain3 };
        public enum eLanguageGain { Gain0, Gain1, Gain2, Gain3 };
        public enum eWeaponProficiencyGain { Gain0, Gain3, Gain4};
        public enum eHitPointGain { Gain0, Gain1, Gain2 };        
        public enum eSpeedGain { Gain0, Gain5, Gain10, Gain15 };
        public enum eInitativeGain { Gain0, Gain1, Gain2, Gain3, Gain4, Gain5 };

        public List<Character.eAbility> abilityIncreases = new List<Character.eAbility>();
        public List<ePrerequisites> prereqs = new List<ePrerequisites>();
        public List<Character.eSkill> skillProficiencies = new List<Character.eSkill>();
        public List<Damage.eDamageType> damageResitances;
        
        public eToolSkillProficiencyGain toolSkillGain = eToolSkillProficiencyGain.Gain0;
        public eLanguageGain languageGain = eLanguageGain.Gain0;
        public eHitPointGain hitPointGain = eHitPointGain.Gain0;
        public eSpeedGain speedBonus = eSpeedGain.Gain0;
        public eInitativeGain initativeBonus = eInitativeGain.Gain0;

        public bool savingThrowProficiency = false;
        public bool improvisedWeaponProficiency = false;
        public bool lightArmorProficiency = false;
        public bool mediumArmorProficiency = false;
        public bool heavyArmorProficiency = false;
        public bool shieldProficiency = false;
        public bool noStealthDisadvantageMedArmor = false;
        public bool mediumArmorACBonus = false;
        public bool dualWeildingACBonus = false;
        public bool dualWeaponFightingWithOneHandedWeapon = false;
        public bool trapSavingThrowAdvantage = false;
        public bool passivePerceptionBonus = false;

        public Feat(string Key, string Name, string OptionPack, string Description)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
            description = Description;
        }

        
    }
}
