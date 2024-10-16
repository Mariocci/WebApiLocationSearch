using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApiLocationSearch.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [JsonIgnore] public string Password { get; set; }
        public string ApiKey { get; set; }
        public ICollection<Log> Logs { get; set; }
        public ICollection<FavoriteLocation> FavoriteLocations { get; set; }
    }
}