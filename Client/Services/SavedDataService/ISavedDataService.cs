global using SkyrimFullStackCrud.Shared;

namespace SkyrimFullStack.Client.Services.SavedDataService
{ 
   public interface ISavedDataService
   {
        List<Player> players {get; set;}
        Task GetPlayers();
        Task<Player> GetPlayer(int id);
   }
}