using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyrimFullStackCrud.Shared.ArmorClass.WearableObjects;

namespace SkyrimFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public static List<Weapon> weapons = new List<Weapon> {
            new Weapon { id = 1, name = "Iron War Axe", attack = 8},
            new Weapon { id = 2, name = "Iron Sword", attack = 7},
            new Weapon { id = 3, name = "Iron Mace", attack = 9}
        };

        public static Helmet helmet = new Helmet(1, "Iron Helmet", 15);
        public static Armor armor = new Armor (1, "Iron Armor", 25);
        public static Gauntlet gauntlets = new Gauntlet(1, "Iron Gauntlets", 10);
        public static Pants pants = new Pants(1, "Iron Greaves", 20);
        public static Boots boots = new Boots(1, "Iron Boots", 10);
    }

}
