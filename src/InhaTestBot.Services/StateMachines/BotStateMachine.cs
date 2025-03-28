using InhaTestBot.Services.Enums;
using Stateless;
using Stateless.Reflection;

namespace InhaTestBot.Services.StateMachines;

// ReSharper disable once ClassNeverInstantiated.Global

public class BotStateMachine 
{
    private readonly StateMachine<MainState, MainTrigger> _machine;

    public BotStateMachine(MainState state)
    {
        _machine = new StateMachine<MainState, MainTrigger>(state);
        
        _machine.Configure(MainState.MainMenu)
            .Permit(MainTrigger.StartCreatingPoll, MainState.CreatingPoll);

        _machine.Configure(MainState.CreatingPoll)
            .Permit(MainTrigger.EnterPollQuestion, MainState.WaitingForPollQuestion)
            .Permit(MainTrigger.Cancel, MainState.MainMenu);

        _machine.Configure(MainState.WaitingForPollQuestion)
            .Permit(MainTrigger.EnterPollOptions, MainState.WaitingForPollOptions)
            .Permit(MainTrigger.Cancel, MainState.MainMenu);

        _machine.Configure(MainState.WaitingForPollOptions)
            .Permit(MainTrigger.ConfirmPoll, MainState.ConfirmingPoll)
            .Permit(MainTrigger.Cancel, MainState.MainMenu);

        _machine.Configure(MainState.ConfirmingPoll)
            .Permit(MainTrigger.SaveAndReturnToMenu, MainState.MainMenu)
            .Permit(MainTrigger.Cancel, MainState.MainMenu);
    }

    public async ValueTask Fire(MainTrigger trigger) => await _machine.FireAsync(trigger);

    public MainState GetCurrentState() => _machine.State;
}


