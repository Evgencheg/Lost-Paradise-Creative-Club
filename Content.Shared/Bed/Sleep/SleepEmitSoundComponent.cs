using Robust.Shared.Audio;

namespace Content.Shared.Bed.Sleep;

[RegisterComponent]
public sealed partial class SleepEmitSoundComponent : Component
{
    /// <summary>
    /// Sound to play when sleeping
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public SoundSpecifier Snore = new SoundCollectionSpecifier("Snores", AudioParams.Default.WithVariation(0.2f));

    /// <summary>
    /// Minimum interval between snore attempts in seconds
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan Interval = TimeSpan.FromSeconds(5);

    /// <summary>
    /// Maximum interval between snore attempts in seconds
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan MaxInterval = TimeSpan.FromSeconds(15);

    /// <summary>
    /// Chance for snore attempt to succeed
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Chance = 0.33f;

    /// <summary>
    /// Popup for snore (e.g. Zzz...)
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public LocId PopUp = "sleep-onomatopoeia";
}
