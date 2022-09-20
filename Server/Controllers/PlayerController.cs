using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyrimFullStackCrud.Shared;
using SkyrimFullStackCrud.Shared.ArmorClass;
using SkyrimFullStackCrud.Shared.ArmorClass.WearableObjects;
using SkyrimFullStackCrud.Shared.OutfitObject.WearableObjects;
using System.Reflection.Emit;

namespace SkyrimFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public static Weapon iAxe = new Weapon(1, "Iron War Axe", 8);
        public static Weapon iSword = new Weapon(1, "Iron Sword", 7);
        public static Weapon iMace = new Weapon(1, "Iron Mace", 9);

        public static Helmet helmet = new(1, "Iron Helmet", 15);
        public static Armor armor = new(1, "Iron Armor", 25);
        public static Gauntlet gauntlets = new(1, "Iron Gauntlets", 10);
        public static Pants pants = new(1, "Iron Greaves", 20);
        public static Boots boots = new(1, "Iron Boots", 10);
        public static Shield shield = new(1, "Iron Shield", 20);

        public static ArmorSet ironOutfit = new(helmet, armor, gauntlets, pants, boots, shield);

        public static List<Player> players = new List<Player>
        {
            new Player
            {
                id = 1,
                firstName = "Alex",
                lastName="Miller",
                race = Shared.Race.Imperial,
                outfit = ironOutfit,
                weapon = iAxe,
                level = 26,
                currXpPts = 23
            },
            new Player
            {
                id = 1,
                firstName = "Sterben",
                lastName="Jeroot",
                race = Shared.Race.Bosmer,
                outfit = ironOutfit,
                weapon = iSword,
                level = 34,
                currXpPts = 74
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Player>>>GetAllSavedData()
        {
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetSavedData(int id)
        {
            var saveData = players.FirstOrDefault(p => p.id == id);
            if (saveData == null)
            {
                return NotFound("Sorry no saved data.");
            }
            return Ok(saveData);
        }
    }

}
