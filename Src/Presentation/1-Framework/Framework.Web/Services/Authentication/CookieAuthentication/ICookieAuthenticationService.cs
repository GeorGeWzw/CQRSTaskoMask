﻿using System.Threading.Tasks;
using TaskoMask.Domain.Core.Models;
using TaskoMask.Domain.Core.Services;

namespace TaskoMask.Presentation.Framework.Web.Services.Authentication.CookieAuthentication
{
    public interface ICookieAuthenticationService: IAuthenticatedUserService
    {
        Task SignInAsync(AuthenticatedUser user, bool isPersistent);
        Task SignOutAsync();
        //TODO adding tow factore and external login
    }
}