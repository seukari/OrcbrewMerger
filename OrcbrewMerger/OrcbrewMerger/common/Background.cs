using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class Background
    {
        public string key = "";
        public string name = "";
        public string optionPack = "";
        public string description = "";

        public enum eLanguageGain { Gain0, Gain1, Gain2, Gain3};
        public enum eToolProficiencyGain { Gain0, Gain1, Gain2, Gain3 };
        public enum eMusicalProficiencyGain { Gain0, Gain1, Gain2, Gain3 };
        public enum eGamingProficiency { Gain0, Gain1, Gain2, Gain3 };
        
        public eLanguageGain languageGain = eLanguageGain.Gain0;
        public eToolProficiencyGain toolProficiencyGain = eToolProficiencyGain.Gain0;

        public List<Feat> feats = new List<Feat>();

        #region Proficiency Bools
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

        public bool proficiencyAlchemy = false;
        public bool proficiencyBrewery = false;
        public bool proficiencyCalligraphy = false;
        public bool proficiencyCarpentry = false;
        public bool proficiencyCartography = false;
        public bool proficiencyCobbling = false;
        public bool proficiencyCooking = false;
        public bool proficiencyGlassblowing = false;
        public bool proficiencyJewling = false;
        public bool proficiencyLeatherworking = false;
        public bool proficiencyMasonry = false;
        public bool proficiencyPainting = false;
        public bool proficiencyPottery = false;
        public bool proficiencySmithing = false;
        public bool proficiencyTinkering = false;
        public bool proficiencyWeaving = false;
        public bool proficiencyWoodcarving = false;

        public bool waterVehicleProficiency = false;
        public bool landVehicleProficiency = false;

        public bool proficiencyDisguiseKit = false;
        public bool proficiencyForgeryKit = false;
        public bool proficiencyHerbalismKit = false;
        public bool proficiencyNavigatorsTools = false;
        public bool proficiencyPoisonersTools = false;
        public bool proficiencyThievesTools = false;
        #endregion

        #region Starting Equipment Bools
        public bool clothesCommon = false;
        public bool clothesCostume = false;
        public bool clothesFine = false;
        public bool clothesTravelers = false;

        public bool suppliesAlchemy = false;
        public bool suppliesBrewery = false;
        public bool suppliesCalligraphy = false;
        public bool suppliesCarpentry = false;
        public bool suppliesCartography = false;
        public bool suppliesCobbling = false;
        public bool suppliesCooking = false;
        public bool suppliesGlassblowing = false;
        public bool suppliesJewling = false;
        public bool suppliesLeatherworking = false;
        public bool suppliesMasonry = false;
        public bool suppliesPainting = false;
        public bool suppliesPottery = false;
        public bool suppliesSmithing = false;
        public bool suppliesTinkering = false;
        public bool suppliesWeaving = false;
        public bool suppliesWoodcarving = false;

        public bool anyOneMusicalInstrument = false;

        public bool suppliesDisguiseKit = false;
        public bool suppliesForgeryKit = false;
        public bool suppliesHerbalismKit = false;
        public bool suppliesNavigatorsTools = false;
        public bool suppliesPoisonersTools = false;
        public bool suppliesThievesTools = false;

        public bool suppliesHolyAmulet = false;
        public bool suppliesHolyEmblem = false;
        public bool suppliesHolyReliquery = false;
        #endregion

        #region Other Equipment
        public bool suppliesAbacus = false;
        public bool suppliesAcid = false;
        public bool suppliesAlchemistsFire = false;
        public bool suppliesAlmsBox = false;
        public bool suppliesAntitoxin = false;
        public bool suppliesBackpack = false;
        public bool suppliesBagOfSand = false;
        public bool suppliesBallBearings = false;
        public bool suppliesBarrel = false;
        public bool suppliesBasket = false;
        public bool suppliesBedroll = false;
        public bool suppliesBell = false;
        public bool suppliesBlanket = false;

        public bool suppliesBlockAndTackle = false;
        public bool suppliesBook = false;
        public bool suppliesBottleGlass = false;
        public bool suppliesBucket = false;
        public bool suppliesCaltrops = false;
        public bool suppliesCandle = false;
        public bool suppliesCaseCrossbowBolt = false;
        public bool suppliesCaseMapScroll = false;
        public bool suppliesCenser = false;
        public bool suppliesChain = false;
        public bool suppliesChalk = false;
        public bool suppliesChest = false;

        public bool suppliesClimbersKit = false;
        public bool suppliesComponentPouch = false;
        public bool suppliesCostume = false;
        public bool suppliesCrowbar = false;
        public bool suppliesFishingTackle = false;
        public bool suppliesFlaskOrTankard = false;
        public bool suppliesGrapplingHook = false;
        public bool suppliesHammer = false;
        public bool suppliesHammerSledge = false;
        public bool suppliesHealersKit = false;

        public bool suppliesHolyWater = false;
        public bool suppliesHolySymbol = false;
        public bool suppliesHourglass = false;
        public bool suppliesHuntingTrap = false;
        public bool suppliesInk = false;
        public bool suppliesInkPen = false;
        public bool suppliesIncense = false;
        public bool suppliesJugOrPitcher = false;
        public bool suppliesKnifeSmall = false;
        public bool suppliesLadder = false;
        public bool suppliesLamp = false;

        public bool suppliesLanternBullseye = false;
        public bool suppliesLanternHooded = false;
        public bool suppliesLock = false;
        public bool suppliesMagnifyingGlass = false;
        public bool suppliesManacles = false;
        public bool suppliesMessKit = false;
        public bool suppliesMirrorSteel = false;
        public bool suppliesOil = false;
        public bool suppliesPaper = false;
        public bool suppliesParchment = false;
        public bool suppliesPerfume = false;

        public bool suppliesPickMiners = false;
        public bool suppliesPiton = false;
        public bool suppliesPoisonBasic = false;
        public bool suppliesPole = false;
        public bool suppliesPot = false;
        public bool suppliesPotionOfHealing = false;
        public bool suppliesPouch = false;
        public bool suppliesPrayerBook = false;
        public bool suppliesPrayerWheel = false;
        public bool suppliesPurse = false;
        public bool suppliesQuiver = false;

        public bool suppliesRamPortable = false;
        public bool suppliesRations = false;
        public bool suppliesRobes = false;
        public bool suppliesRopeHempen = false;
        public bool suppliesRopeSilk = false;
        public bool suppliesSack = false;
        public bool suppliesScaleMerchants = false;
        public bool suppliesSealingWax = false;
        public bool suppliesShovel = false;
        public bool suppliesSignalWhistle = false;
        public bool suppliesSignetRing = false;

        public bool suppliesSoap = false;
        public bool suppliesSpellbook = false;
        public bool suppliesSpikesIron = false;
        public bool suppliesSpyglass = false;
        public bool suppliesString = false;
        public bool suppliesTentTwoPerson = false;
        public bool suppliesTinderbox = false;
        public bool suppliesTorch = false;
        public bool suppliesVial = false;
        public bool suppliesVestements = false;
        public bool suppliesWaterskin = false;
        public bool suppliesWhetstone = false;
        public bool suppliesWoodenStake = false;
        #endregion

        public Background()
        {

        }

        public Background(string Key, string Name, string OptionPack, string Description)
        {
            key = Key;
            name = Name;
            optionPack = OptionPack;
            description = Description;
        }

    }
}
