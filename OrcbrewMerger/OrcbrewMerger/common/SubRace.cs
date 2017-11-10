using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class SubRace
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";

        public Race race = new Race();

        public enum eSubRaceSize { Small, Medium, Large };
        public enum eSubRaceSpeed { TwentyFive, Thirty, ThirtyFive };
        public enum eSubRaceDarkvision { Zero, Sixty, OneTwenty };
        public enum eSubRaceStatIncrease { MinusTwo, MinusOne, Zero, One, Two };

        public eSubRaceSize subRaceSize = eSubRaceSize.Medium;
        public eSubRaceSpeed subRaceSpeed = eSubRaceSpeed.Thirty;
        public eSubRaceDarkvision subRaceDarkvision = eSubRaceDarkvision.Zero;

        public eSubRaceStatIncrease subRaceStrength = eSubRaceStatIncrease.Zero;
        public eSubRaceStatIncrease subRaceConstitution = eSubRaceStatIncrease.Zero;
        public eSubRaceStatIncrease subRaceDexterity = eSubRaceStatIncrease.Zero;
        public eSubRaceStatIncrease subRaceIntelligence = eSubRaceStatIncrease.Zero;
        public eSubRaceStatIncrease subRaceWisdom = eSubRaceStatIncrease.Zero;
        public eSubRaceStatIncrease subRaceCharisma = eSubRaceStatIncrease.Zero;

        #region Languages
        public bool languageAbyssal = false;
        public bool languageCelestial = false;
        public bool languageCommon = false;
        public bool languageDeepSpeech = false;
        public bool languageDraconic = false;
        public bool languageDwarvish = false;
        public bool languageElvish = false;
        public bool languageGiant = false;
        public bool languageGnomish = false;
        public bool languageGoblin = false;
        public bool languageHalfling = false;
        public bool languageInfernal = false;
        public bool languageOrc = false;
        public bool languagePrimordial = false;
        public bool languageSylvan = false;
        public bool languageUndercommon = false;
        #endregion

        #region Weapon Proficiency
        public bool proficiencyAllSimpleWeapons = false;
        public bool proficiencyAllMartialWeapons = false;
        public bool proficiencyBattleaxe = false;
        public bool proficiencyBlowGun = false;
        public bool proficiencyCrossbowLight = false;
        public bool proficiencyCrossbowHand = false;
        public bool proficiencyCrossbowHeavy = false;
        public bool proficiencyClub = false;
        public bool proficiencyDagger = false;
        public bool proficiencyDart = false;
        public bool proficiencyFlail = false;
        public bool proficiencyGlaive = false;
        public bool proficiencyGreataxe = false;
        public bool proficiencyGreatclub = false;
        public bool proficiencyGreatsword = false;
        public bool proficiencyHalberd = false;
        public bool proficiencyHandaxe = false;
        public bool proficiencyJavalin = false;
        public bool proficiencyLance = false;
        public bool proficiencyLightHammer = false;
        public bool proficiencyLongbow = false;
        public bool proficiencyLongsword = false;
        public bool proficiencyMace = false;
        public bool proficiencyMaul = false;
        public bool proficiencyMorningstar = false;
        public bool proficiencyNet = false;
        public bool proficiencyPike = false;
        public bool proficiencyQuaterstaff = false;
        public bool proficiencyRapier = false;
        public bool proficiencySickle = false;
        public bool proficiencySling = false;
        public bool proficiencyShortsword = false;
        public bool proficiencyShortbow = false;
        public bool proficiencyScimitar = false;
        public bool proficiencySpear = false;
        public bool proficiencyTrident = false;
        public bool proficiencyThunderCannon = false;
        public bool proficiencyWarPick = false;
        public bool proficiencyWarhammer = false;
        public bool proficiencyWhip = false;
        #endregion

        #region Armor Proficiency
        public bool proficiencyLightArmor = false;
        public bool proficiencyMediumArmor = false;
        public bool proficiencyHeavyArmor = false;
        public bool proficiencyShield = false;
        #endregion

        #region Skill Proficiency
        public bool proficiencyAcrobatics = false;
        public bool proficiencyAnimalHandling = false;
        public bool proficiencyArcana = false;
        public bool proficiencyAthletics = false;
        public bool proficiencyDeception = false;
        public bool proficiencyHistory = false;
        public bool proficiencyInsight = false;
        public bool proficiencyIntimidation = false;
        public bool proficiencyInvestigation = false;
        public bool proficiencyMedicine = false;
        public bool proficiencyNature = false;
        public bool proficiencyPerception = false;
        public bool proficiencyPerformance = false;
        public bool proficiencyPersuasion = false;
        public bool proficiencyReligion = false;
        public bool proficiencySleightOfHand = false;
        public bool proficiencyStealth = false;
        public bool proficiencySurvival = false;
        #endregion

        #region Damage Resitance
        public bool resistanceTraps = false;
        public bool resistanceAcid = false;
        public bool resistanceBludgeoning = false;
        public bool resistanceCold = false;
        public bool resistanceFire = false;
        public bool resistanceForce = false;
        public bool resistanceLightning = false;
        public bool resistanceNecrotic = false;
        public bool resistancePiercing = false;
        public bool resistancePoison = false;
        public bool resistancePsychic = false;
        public bool resistanceRadient = false;
        public bool resistanceSlashing = false;
        public bool resistanceThunder = false;
        #endregion

        #region Damage Immunity
        public bool immunityTraps = false;
        public bool immunityAcid = false;
        public bool immunityBludgeoning = false;
        public bool immunityCold = false;
        public bool immunityFire = false;
        public bool immunityForce = false;
        public bool immunityLightning = false;
        public bool immunityNecrotic = false;
        public bool immunityPiercing = false;
        public bool immunityPoison = false;
        public bool immunityPsychic = false;
        public bool immunityRadient = false;
        public bool immunitySlashing = false;
        public bool immunityThunder = false;
        #endregion

        #region Saving Throw Advantage
        public bool advantageBlinded = false;
        public bool advantageCharmed = false;
        public bool advantageDeafened = false;
        public bool advantageFrightened = false;
        public bool advantageGrappled = false;
        public bool advantageIncapacitated = false;
        public bool advantageInvisible = false;
        public bool advantageParalyzed = false;
        public bool advantagePetrified = false;
        public bool advantagePoisoned = false;
        public bool advantageProne = false;
        public bool advantageRestrained = false;
        public bool advantageStunned = false;
        public bool advantageUnconcious = false;
        #endregion

        public List<Language> customLanguages = new List<Language>();
        public List<CastableSpell> spells = new List<CastableSpell>();
        public List<Feat> feats = new List<Feat>();

        public SubRace()
        {

        }

        public SubRace(string Key, string Name, string OptionPack)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
        }
    }
}
