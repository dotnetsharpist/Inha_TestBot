using InhaTestBot.Services.Enums;
using InhaTestBot.Services.StateMachines;

namespace InhaTestBot.Services.Interfaces;

public interface IStateService
{
    ValueTask<BotStateMachine> GetUserStateMachine(long userId);
    ValueTask SetUserState(long userId, BotStateMachine mainState);
    ValueTask<MainState> GetUserState(long userId);
}