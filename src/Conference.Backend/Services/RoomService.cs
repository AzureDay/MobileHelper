using System.Collections.Generic;
using System.Linq;
using Conference.DataObjects;

namespace Conference.Backend.Services
{
    public class RoomService : BaseService<Room>
    {
        protected override List<Room> PopulateStorage()
        {
            return new List<Room>
            {
                new Room { Name = AzureDay.WebApp.Localization.App.Service.Room.AInML, ImageUrl = string.Empty, },
                new Room { Name = AzureDay.WebApp.Localization.App.Service.Room.DevOps, ImageUrl = string.Empty, },
            };
        }

        public Room Room1 { get { return Storage.Single(x => x.Name == AzureDay.WebApp.Localization.App.Service.Room.AInML); } }
        public Room Room2 { get { return Storage.Single(x => x.Name == AzureDay.WebApp.Localization.App.Service.Room.DevOps); } }
    }
}