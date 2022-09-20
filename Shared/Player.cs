using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyrimFullStackCrud.Shared.ArmorClass;

namespace SkyrimFullStackCrud.Shared
{
    enum Race
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

    internal class Player
    {
        public int Id { get; set; }
        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;
        public Race race { get; set; } = Race.Nord;
        public ArmorSet? outfit { get; set; }
        public Weapon? weapon { get; set; }
        public int level { get; set; } = 0;
        public int currXpPts { get; set; } = 0;
        static public int XpCap { get; set; } = 100;
    }
}
