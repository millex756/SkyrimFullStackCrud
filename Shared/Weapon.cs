namespace SkyrimFullStackCrud.Shared
{
    public class Weapon
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public long attack { get; set; } = 0;

        public Weapon(int id, string name, long attack)
        {
            this.id = id;
            this.name = name;
            this.attack = attack;
        }
    }
}