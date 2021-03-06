using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class TrainingFoilIVRed: AbstractQuest
    {
        public TrainingFoilIVRed()
        {
            CreateQuest(560, "Engineering Guild Task: 1x Training Foil IV (Red)", "eng_tsk_560")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "lightsaber_r_4", 1, true)

                .AddRewardGold(505)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 105);
        }
    }
}
