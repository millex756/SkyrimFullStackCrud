namespace SkyrimFullStackCrud.Shared.ArmorClass
{
    public class Wearable
    {
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public long defense { get; set; } = 0;

        public Wearable (int id, string name, long defense)
        {
            this.id = id;
            this.name = name;
            this.defense = defense;
        }
    }
}