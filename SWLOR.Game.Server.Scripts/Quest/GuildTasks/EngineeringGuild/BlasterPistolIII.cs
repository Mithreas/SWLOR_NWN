using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class BlasterPistolIII: AbstractQuest
    {
        public BlasterPistolIII()
        {
            CreateQuest(454, "Engineering Guild Task: 1x Blaster Pistol III", "eng_tsk_454")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "blaster_3", 1, true)

                .AddRewardGold(285)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 59);
        }
    }
}
