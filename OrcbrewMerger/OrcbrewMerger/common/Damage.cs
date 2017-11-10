using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcbrewMerger.common
{
    public class Damage
    {
        public Creature source = new Creature();
        public List<Creature> targets = new List<Creature>();
        public enum eDamageType { Acid, Bludgeoning, Cold, Fire, Force, Lightning, Necrotic, Piercing, Poison, Psychic, Radient, Slashing, Thunder };
        public int hpModifier = 0;
    }
}
