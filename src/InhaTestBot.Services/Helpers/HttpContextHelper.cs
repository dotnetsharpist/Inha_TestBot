using Microsoft.AspNetCore.Http;

namespace InhaTestBot.Services.Helpers;

public class HttpContextHelper
{
    public static IHttpContextAccessor Accessor { get; set; }
    public static HttpContext HttpContext => Accessor?.HttpContext;
    public static IHeaderDictionary ResponseHeaders => HttpContext?.Response?.Headers;
}