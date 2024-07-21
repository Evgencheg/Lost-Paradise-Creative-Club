using System.Linq;
using Content.Client.Lobby;
using Content.Client.Corvax.Sponsors;
using Content.Client.Corvax.TTS;
using Content.Shared.Corvax.TTS;
using Content.Shared.Preferences;
using Robust.Client.UserInterface;
using Robust.Client.GameObjects;

namespace Content.Client.Lobby.UI;

public sealed partial class HumanoidProfileEditor
{
    private List<TTSVoicePrototype> _voiceList = default!;
    private void InitializeVoice()
    {
        _voiceList = _prototypeManager
            .EnumeratePrototypes<TTSVoicePrototype>()
            .Where(o => o.RoundStart)
            .OrderBy(o => Loc.GetString(o.Name))
            .ToList();

        VoiceButton.OnItemSelected += args =>
        {
            VoiceButton.SelectId(args.Id);
            SetVoice(_voiceList[args.Id].ID);
        };

        VoicePlayButton.OnPressed += _ => PlayPreviewTTS();
    }

    private void PlayPreviewTTS()
    {
        if (Profile is null)
            return;

        _entManager.System<TTSSystem>().RequestPreviewTTS(Profile.Voice);
    }
}
