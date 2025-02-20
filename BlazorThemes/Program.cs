using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorThemes;
using BlazorThemes.Components;
using BlazorThemes.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<SignInManager<ApplicationUser>>();

builder.Services.AddScoped<UserManager<ApplicationUser>>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();

public class SignInManager<T>
{
    public async Task<object> PasswordSignInAsync(string inputEmail, string inputPassword, bool inputRememberMe, bool lockoutOnFailure)
    {
        throw new NotImplementedException();
    }

    public async Task GetExternalAuthenticationSchemesAsync()
    {
        throw new NotImplementedException();
    }
}