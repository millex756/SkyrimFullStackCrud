using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyrimFullStackCrud.Shared.ArmorClass;
using SkyrimFullStackCrud.Shared.OutfitObject;

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
        public ArmorSet? armor { get; set; } = null;
        public int level { get; set; } = 0;
        public int currXpPts { get; set; } = 0;
        static public int XpCap { get; set; } = 100;
    }
}
