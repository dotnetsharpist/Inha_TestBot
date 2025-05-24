namespace InhaTestBot.Domain.Exceptions;

public class InhaTestException(int code = 500, string message = "Something went wrong") : Exception(message)
{
    public int Code { get; set; } = code;
}