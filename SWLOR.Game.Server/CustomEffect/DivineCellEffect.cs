﻿using NWN;
using SWLOR.Game.Server.CustomEffect.Contracts;
using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.GameObject;
using SWLOR.Game.Server.Service;

using static NWN._;

namespace SWLOR.Game.Server.CustomEffect
{
    public class DivineCellEffect: ICustomEffectHandler
    {
        public CustomEffectCategoryType CustomEffectCategoryType => CustomEffectCategoryType.NormalEffect;
        public CustomEffectType CustomEffectType => CustomEffectType.DivineCell;

        public string Apply(NWCreature oCaster, NWObject oTarget, int effectiveLevel)
        {
            oCaster.SendMessage("A divine cell lands on your target.");
            return null;
        }

        public void Tick(NWCreature oCaster, NWObject oTarget, int currentTick, int effectiveLevel, string data)
        {
            if (currentTick % 2 != 0) return;
            int damage = RandomService.D4(1);
            oTarget.SetLocalInt(AbilityService.LAST_ATTACK + oCaster.GlobalID, AbilityService.ATTACK_DOT);

            oCaster.AssignCommand(() =>
            {
                _.ApplyEffectToObject(DURATION_TYPE_INSTANT, _.EffectDamage(damage, DAMAGE_TYPE_DIVINE), oTarget);
            });
            
        }

        public void WearOff(NWCreature oCaster, NWObject oTarget, int effectiveLevel, string data)
        {
        }

        public string StartMessage => "You have been hit with a divine cell.";
        public string ContinueMessage => "";
        public string WornOffMessage => "The effect of the divine cell dissipates.";
    }
}
