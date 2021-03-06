using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class TrainingFoilIIYellow: AbstractQuest
    {
        public TrainingFoilIIYellow()
        {
            CreateQuest(482, "Engineering Guild Task: 1x Training Foil II (Yellow)", "eng_tsk_482")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "lightsaber_y_2", 1, true)

                .AddRewardGold(305)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 65);
        }
    }
}
