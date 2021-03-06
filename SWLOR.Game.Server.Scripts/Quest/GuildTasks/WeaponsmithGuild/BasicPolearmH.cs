using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.WeaponsmithGuild
{
    public class BasicPolearmH: AbstractQuest
    {
        public BasicPolearmH()
        {
            CreateQuest(231, "Weaponsmith Guild Task: 1x Basic Polearm H", "wpn_tsk_231")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "halberd_b", 1, true)

                .AddRewardGold(35)
                .AddRewardGuildPoints(GuildType.WeaponsmithGuild, 9);
        }
    }
}
