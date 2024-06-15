using Common;
using Microsoft.Extensions.Configuration;
using IDispatcher = Fluxor.IDispatcher;

namespace MauiPong.Components.Pages.Pong.Store;

internal class PongEffects
{
    private readonly IConfiguration _cfg;
    private readonly IDispatcher _dispatcher;
    private readonly ILogger<PongEffects> _log;
    private HubConnection? _hubConnection;


    public PongEffects(ILogger<PongEffects> log, IDispatcher dispatcher, IConfiguration cfg)
    {
        _log = log;
        _cfg = cfg;
        _dispatcher = dispatcher;

        _ = StartHubAsync();
    }

    public async Task<HubConnectionState> StartHubAsync()
    {
        await Task.Run(() =>
        {
            var hubUrl = "http://localhost:5000/pongHub";
            //var hubUrl = _cfg.GetSection("HubUrl").Value;
            if (_hubConnection == null)
                if (hubUrl != null)
                    _hubConnection = new HubConnectionBuilder()
                        .WithUrl(hubUrl)
                        .Build();

           

            _hubConnection?.On<PongGameState>(SignalrConstants.GameSateChanged,
                state => { _dispatcher.Dispatch(new GameStateChangedAction(state)); });
        });


        return _hubConnection!.State;
    }
}

