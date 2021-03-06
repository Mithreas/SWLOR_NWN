using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class PowerGloveI: AbstractQuest
    {
        public PowerGloveI()
        {
            CreateQuest(141, "Armorsmith Guild Task: 1x Power Glove I", "arm_tsk_141")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "powerglove_1", 1, true)

                .AddRewardGold(85)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 19);
        }
    }
}
