using Content.Shared.Chat;
using Content.Shared.Radio;
//using Content.Shared.Language;

namespace Content.Server.Radio;

[ByRefEvent]
public readonly record struct RadioReceiveEvent(
    EntityUid MessageSource,
    RadioChannelPrototype Channel,
    ChatMessage UnderstoodChatMsg,
    ChatMessage NotUnderstoodChatMsg,
    EntityUid RadioSource//,
    //LanguagePrototype Language
);

/// <summary>
/// Use this event to cancel sending message per receiver
/// </summary>
[ByRefEvent]
public record struct RadioReceiveAttemptEvent(RadioChannelPrototype Channel, EntityUid RadioSource, EntityUid RadioReceiver)
{
    public readonly RadioChannelPrototype Channel = Channel;
    public readonly EntityUid RadioSource = RadioSource;
    public readonly EntityUid RadioReceiver = RadioReceiver;
    public bool Cancelled = false;
}

/// <summary>
/// Use this event to cancel sending message to every receiver
/// </summary>
[ByRefEvent]
public record struct RadioSendAttemptEvent(RadioChannelPrototype Channel, EntityUid RadioSource)
{
    public readonly RadioChannelPrototype Channel = Channel;
    public readonly EntityUid RadioSource = RadioSource;
    public bool Cancelled = false;
}
