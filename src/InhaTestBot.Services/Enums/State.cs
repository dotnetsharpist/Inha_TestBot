namespace InhaTestBot.Services.Enums;

public enum MainState
{
    MainMenu,
    CreatingPoll,
    WaitingForPollQuestion,  
    WaitingForPollOptions,   
    ConfirmingPoll
}


public enum MainTrigger
{
    StartCreatingPoll,        // From MainMenu → CreatingPoll
    EnterPollQuestion,        // CreatingPoll → WaitingForPollQuestion
    EnterPollOptions,         // WaitingForPollQuestion → WaitingForPollOptions
    ConfirmPoll,              // WaitingForPollOptions → ConfirmingPoll
    SaveAndReturnToMenu,      // ConfirmingPoll → MainMenu
    Cancel,                   // From any state → MainMenu (universal cancel)
}
