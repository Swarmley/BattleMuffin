using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPMatchStatistics
    {
        [JsonProperty("played")]
        public int Played { get; set; }

        [JsonProperty("won")]
        public int Won { get; set; }

        [JsonProperty("lost")]
        public int Lost { get; set; }
    }
}