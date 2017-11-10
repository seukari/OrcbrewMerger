using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class Character : Creature
    {
        public enum eAbility { Strength, Constitution, Dexterity, Intelligence, Wisdom, Charisma };
        public enum eSkill { Acrobatics, AnimalHandling, Arcana, Athletics, Deception, History, Insight, Intimidation, Investigation, Medicine, Nature, Perception, Performance, Persuasion, Religion, SlightOfHand, Stealth, Survival };

        public Race race = new Race();
        public SubRace subrace = new SubRace();
        public Background background = new Background();
        public Class characterClass = new Class();
        public SubClass subClass = new SubClass();

        public uint level = 0;
        public int healthPoints = 0;

        public string alignment = "";

        #region Abilities
        public int strength = 0;
        public int constitution = 0;
        public int dexterity = 0;
        public int intelligence = 0;
        public int wisdom = 0;
        public int charisma = 0;

        public int strengthMod = 0;
        public int constitutionMod = 0;
        public int dexterityMod = 0;
        public int intelligenceMod = 0;
        public int wisdomMod = 0;
        public int charismaMod = 0;
        #endregion

        public List<Feat> feats = new List<Feat>();
    }
}
