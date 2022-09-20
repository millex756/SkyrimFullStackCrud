﻿using SkyrimFullStackCrud.Shared.ArmorClass.WearableObjects;
using SkyrimFullStackCrud.Shared.OutfitObject;

namespace SkyrimFullStackCrud.Shared.ArmorClass
{
    public class ArmorSet
    {
        public Helmet? helmet { get; set; } = null;
        public Armor? armor { get; set; } = null;
        public Gauntlet? gauntlet { get; set; } = null;
        public Pants? pants { get; set; } = null;
        public Boots? boots { get; set; } = null;

        public Weapon? weapon { get; set; } = null;
    }
}