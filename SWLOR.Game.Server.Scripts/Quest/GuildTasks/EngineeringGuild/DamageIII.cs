using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class DamageIII: AbstractQuest
    {
        public DamageIII()
        {
            CreateQuest(514, "Engineering Guild Task: 1x Damage III", "eng_tsk_514")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "rune_dmg3", 1, true)

                .AddRewardGold(430)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 90);
        }
    }
}
