using InhaTestBot.Services.Enums;
using InhaTestBot.Services.Infrastructure;
using InhaTestBot.Services.Interfaces;
using InhaTestBot.Services.StateMachines;

namespace InhaTestBot.Services.Services;

public class StateService(RedisService redis) : IStateService
{
    public async ValueTask<BotStateMachine> GetUserStateMachine(long userId)
    {
        var stateStr = await redis.GetValueAsync<string>($"user_state:{userId}");
        var lastState = stateStr == null ? MainState.MainMenu : Enum.Parse<MainState>(stateStr);
        return new BotStateMachine(lastState); 
    }
    
    public async ValueTask<MainState> GetUserState(long userId)
    {
        var stateStr = await redis.GetValueAsync<string>($"user_state:{userId}");
        return stateStr == null ? MainState.MainMenu : Enum.Parse<MainState>(stateStr);
    }

    public async ValueTask SetUserState(long userId, BotStateMachine stateMachine)
    {
        await redis.SetValueAsync($"user_state:{userId}", stateMachine.GetCurrentState().ToString());
    } 
}