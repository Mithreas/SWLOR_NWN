using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class FabricationI: AbstractQuest
    {
        public FabricationI()
        {
            CreateQuest(390, "Engineering Guild Task: 1x Fabrication I", "eng_tsk_390")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "rune_fab1", 1, true)

                .AddRewardGold(70)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 15);
        }
    }
}
