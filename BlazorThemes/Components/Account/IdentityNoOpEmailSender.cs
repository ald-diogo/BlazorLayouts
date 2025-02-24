﻿using BlazorThemes.Components.Account.Pages.Manage;
using Microsoft.AspNetCore.Identity;

using BlazorThemes.Data;

namespace BlazorThemes.Components.Account;

// Remove the "else if (EmailSender is IdentityNoOpEmailSender)" block from RegisterConfirmation.razor after updating with a real implementation.
internal sealed class IdentityNoOpEmailSender : Email.IEmailSender<ApplicationUser>
{
    private readonly NoOpEmailSender emailSender = new NoOpEmailSender();

    public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
        emailSender.SendEmailAsync(email, "Confirm your email", $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.");

    public Task SendEmailAsync(string s, string confirmYourEmail, string s1)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
        emailSender.SendEmailAsync(email, "Reset your password", $"Please reset your password by <a href='{resetLink}'>clicking here</a>.");
 
    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
        emailSender.SendEmailAsync(email, "Reset your password", $"Please reset your password using the following code: {resetCode}");
}

internal class NoOpEmailSender
{
    public Task SendEmailAsync(string email, string confirmYourEmail, string s)
    {
        throw new NotImplementedException();
    }
}