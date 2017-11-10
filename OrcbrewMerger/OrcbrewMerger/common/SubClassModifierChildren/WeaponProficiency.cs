using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common.SubClassModifierChildren
{
    public class WeaponProficiency : SubClassModifier
    {
        public enum eWeaponProficiency { AllSimple, AllMartial, Dart, Shortbow, Sling, Club, Dagger, Greatclub, Handaxe, Javelin, LightHammer, Mace, Quaterstaff, Sickle, Spear, Battleaxe, Flail, Glaive, Greataxe, Greatsword, Halberd, Lance, Longsword, Maul, Morningstar, Pike, Rapier, Scimitar, Shortsword, Trident, Warpick, Warhammer, Whip, Blowgun, CrossbowHand, CrossbowHeavy, ThunderCannon, Longbow, Net };

        public eWeaponProficiency weaponProficiency = eWeaponProficiency.AllSimple;        

        public WeaponProficiency(eWeaponProficiency proficiency)
        {
            weaponProficiency = proficiency;
        }        
    }
}
