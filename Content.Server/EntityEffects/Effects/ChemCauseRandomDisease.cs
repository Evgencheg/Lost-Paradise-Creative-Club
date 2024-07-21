//using Content.Shared.Chemistry.Reagent;
/*using Content.Server.Disease;
using Content.Shared.Disease;
using Robust.Shared.Random;
using JetBrains.Annotations;
using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.Effects
{
    /// <summary>
    /// Causes a random disease from a list, if the user is not already diseased.
    /// </summary>
    [UsedImplicitly]
    public sealed partial class ChemCauseRandomDisease : EntityEffect
    {
        /// <summary>
        /// A disease to choose from.
        /// </summary>
        [DataField("diseases", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public List<string> Diseases = default!;

        protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
            => Loc.GetString("reagent-effect-guidebook-cause-disease");

        public override void Effect(EntityEffectBaseArgs args)
        {
            if (args.EntityManager.TryGetComponent<DiseasedComponent>(args.TargetEntity, out var diseased))
                return;

            if (args is EntityEffectReagentArgs reagentArgs)
                if (reagentArgs.Scale != 1f)
                    return;

            var random = IoCManager.Resolve<IRobustRandom>();

            EntitySystem.Get<DiseaseSystem>().TryAddDisease(args.TargetEntity, random.Pick(Diseases));
        }
    }
}*/
