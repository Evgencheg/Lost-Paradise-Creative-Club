/*using Content.Shared.Chemistry.Reagent;
using Content.Server.Disease;
using Content.Shared.EntityEffects;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.Effects
{
    /// <summary>
    /// Default metabolism for medicine reagents.
    /// </summary>
    [UsedImplicitly]
    public sealed partial class ChemCureDisease : EntityEffect
    {
        /// <summary>
        /// Chance it has each tick to cure a disease, between 0 and 1
        /// </summary>
        [DataField("cureChance")]
        public float CureChance = 0.50f;

        protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
            => Loc.GetString("reagent-effect-guidebook-cure-disease", ("chance", Probability));

        public override void Effect(EntityEffectBaseArgs args)
        {
            var cureChance = CureChance;

            if (args is EntityEffectReagentArgs reagentArgs)
                cureChance *= reagentArgs.Scale.Float();

            var ev = new CureDiseaseAttemptEvent(cureChance);
            args.EntityManager.EventBus.RaiseLocalEvent(args.TargetEntity, ev, false);
        }
    }
}*/
