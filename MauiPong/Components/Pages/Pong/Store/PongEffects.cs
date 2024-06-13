
using Microsoft.Extensions.Logging;

namespace MauiPong.Components.Pages.Pong.Store;

internal class PongEffects
{
    private readonly ILogger<PongEffects> _log;

    public PongEffects(ILogger<PongEffects> log)
    {
        _log = log;
    }
}