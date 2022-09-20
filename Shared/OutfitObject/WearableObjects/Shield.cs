using SkyrimFullStackCrud.Shared.ArmorClass;

namespace SkyrimFullStackCrud.Shared.OutfitObject.WearableObjects
{
    public class Shield : Wearable
    {
        public Shield(int id, string name, long defense) : base(id, name, defense)
        {
        }
    }
}