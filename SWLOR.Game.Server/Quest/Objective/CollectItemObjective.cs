﻿using SWLOR.Game.Server.Data.Entity;
using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.GameObject;
using SWLOR.Game.Server.Quest.Contracts;
using SWLOR.Game.Server.Service;

namespace SWLOR.Game.Server.Quest.Objective
{
    public class CollectItemObjective: IQuestObjective
    {
        private readonly string _resref;
        private readonly int _quantity;
        private readonly bool _mustBeCraftedByPlayer;

        public CollectItemObjective(string resref, int quantity, bool mustBeCraftedByPlayer)
        {
            _resref = resref;
            _quantity = quantity;
            _mustBeCraftedByPlayer = mustBeCraftedByPlayer;
        }

        public void Initialize(NWPlayer player, int questID)
        {
            var status = DataService.PCQuestStatus.GetByPlayerAndQuestID(player.GlobalID, questID);
            PCQuestItemProgress itemProgress = new PCQuestItemProgress
            {
                Resref = _resref,
                PlayerID = status.PlayerID,
                PCQuestStatusID = status.ID,
                Remaining = _quantity,
                MustBeCraftedByPlayer = _mustBeCraftedByPlayer
            };
            DataService.SubmitDataChange(itemProgress, DatabaseActionType.Insert);
        }

        public bool IsComplete(NWPlayer player, int questID)
        {
            var status = DataService.PCQuestStatus.GetByPlayerAndQuestID(player.GlobalID, questID);
            var itemProgress = DataService.PCQuestItemProgress.GetAllByPCQuestStatusID(status.ID);
            foreach (var progress in itemProgress)
            {
                if (progress.Remaining > 0)
                    return false;
            }

            return true;
        }
    }
}
