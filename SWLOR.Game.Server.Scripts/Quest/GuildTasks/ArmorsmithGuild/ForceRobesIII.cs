using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class ForceRobesIII: AbstractQuest
    {
        public ForceRobesIII()
        {
            CreateQuest(177, "Armorsmith Guild Task: 1x Force Robes III", "arm_tsk_177")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "force_robe_3", 1, true)

                .AddRewardGold(285)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 59);
        }
    }
}
