using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class LightArmorRepairKitII: AbstractQuest
    {
        public LightArmorRepairKitII()
        {
            CreateQuest(160, "Armorsmith Guild Task: 1x Light Armor Repair Kit II", "arm_tsk_160")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "la_rep_2", 1, true)

                .AddRewardGold(220)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 48);
        }
    }
}
