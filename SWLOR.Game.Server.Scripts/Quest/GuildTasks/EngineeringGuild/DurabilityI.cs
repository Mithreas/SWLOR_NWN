using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class DurabilityI: AbstractQuest
    {
        public DurabilityI()
        {
            CreateQuest(421, "Engineering Guild Task: 1x Durability I", "eng_tsk_421")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "rune_dur1", 1, true)

                .AddRewardGold(190)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 40);
        }
    }
}
