using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyrimFullStackCrud.Shared.ArmorClass;

namespace SkyrimFullStackCrud.Shared
{
    public enum Race
    {
        Altmer,
        Argonian,
        Bosmer,
        Breton,
        Dunmer,
        Imperial,
        Khajiit,
        Nord,
        Orc,
        Redguard
    }

    public class Player
    {
        public int id { get; set; }
        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;
        public Race race { get; set; } = Race.Nord;
        public ArmorSet? outfit { get; set; }
        public Weapon? weapon { get; set; }
        public int level { get; set; } = 0;
        public int currXpPts { get; set; } = 0;
        public int xpCap { get; set; } = 0;

        public string GetXpProgress()
        {
            return (currXpPts + " / " + xpCap);
        }

        public Player(int _id, string _firstName, string _lastName, Race _race)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
            race = _race;
            weapon = null;
            outfit = null; // set to basic prisoner clothes
            level = 1;
            currXpPts = 0;
            xpCap = this.CalculateXpCap(level);
        }

        private int CalculateXpCap(int lvl)
        { return lvl * 12;}
    }
}
