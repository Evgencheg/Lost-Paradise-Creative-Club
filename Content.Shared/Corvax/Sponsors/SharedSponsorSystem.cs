using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;
using Lidgren.Network;
using Robust.Shared.Network;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.Corvax.Sponsors;

public sealed class SharedSponsorsManager
{
    private readonly Dictionary<NetUserId, SponsorInfo> _cachedSponsors = new();

    public bool TryGetPrototypes(NetUserId userId, [NotNullWhen(true)] out List<string>? prototypes)
    {
        if (!_cachedSponsors.ContainsKey(userId) || _cachedSponsors[userId].AllowedMarkings.Length == 0)
        {
            prototypes = null;
            return false;
        }

        prototypes = new List<string>();
        prototypes.AddRange(_cachedSponsors[userId].AllowedMarkings);

        return true;
    }
}
