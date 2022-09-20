using SkyrimFullStackCrud.Shared.ArmorClass.WearableObjects;
using SkyrimFullStackCrud.Shared.OutfitObject.WearableObjects;

namespace SkyrimFullStackCrud.Shared.ArmorClass
{
    public class ArmorSet
    {
        public Helmet? helmet { get; set; } = null;
        public Armor? armor { get; set; } = null;
        public Gauntlet? gauntlet { get; set; } = null;
        public Pants? pants { get; set; } = null;
        public Boots? boots { get; set; } = null;

        public Shield? shield { get; set; } = null;

        public ArmorSet (Helmet? helmet, Armor? armor, Gauntlet? gauntlet, Pants? pants, Boots? boots, Shield? shield)
        {
            this.helmet = helmet;
            this.armor = armor;
            this.gauntlet = gauntlet;
            this.pants = pants;
            this.boots = boots;
            this.shield = shield;
        }
    }
}