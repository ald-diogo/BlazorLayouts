using Microsoft.AspNetCore.Http;

namespace BlazorThemes.Components;

public class IdentityRedirectManager
{
    public static string StatusCookieName { get; }

    public void RedirectToWithStatus(string accountInvaliduser, string s, HttpContext context)
    {
        throw new NotImplementedException();
    }
}