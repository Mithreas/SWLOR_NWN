using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.WeaponsmithGuild
{
    public class PolearmH4: AbstractQuest
    {
        public PolearmH4()
        {
            CreateQuest(337, "Weaponsmith Guild Task: 1x Polearm H4", "wpn_tsk_337")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "halberd_4", 1, true)

                .AddRewardGold(385)
                .AddRewardGuildPoints(GuildType.WeaponsmithGuild, 79);
        }
    }
}
