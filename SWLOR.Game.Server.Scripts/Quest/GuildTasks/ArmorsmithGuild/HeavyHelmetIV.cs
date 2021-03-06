using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class HeavyHelmetIV: AbstractQuest
    {
        public HeavyHelmetIV()
        {
            CreateQuest(204, "Armorsmith Guild Task: 1x Heavy Helmet IV", "arm_tsk_204")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "helmet_h4", 1, true)

                .AddRewardGold(385)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 79);
        }
    }
}
