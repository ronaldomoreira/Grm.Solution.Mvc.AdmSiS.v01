﻿using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace GrmWebAppAdmSiSv01.Extensions.Identity
{
    public static class ClaimsExtensions
    {
        static string GetUserEmail(this ClaimsIdentity identity)
        {
            return identity.Claims?.FirstOrDefault(c => c.Type == "GrmWebAppAdmSiSv01.Models.Identity.RegisterViewModel.Email")?.Value;
        }

        public static string GetUserEmail(this IIdentity identity)
        {
            var claimsIdentity = identity as ClaimsIdentity;
            return claimsIdentity != null ? GetUserEmail(claimsIdentity) : "";
        }

        static string GetUserNameIdentifier(this ClaimsIdentity identity)
        {
            return identity.Claims?.FirstOrDefault(c => c.Type == "GrmWebAppAdmSiSv01.Models.Identity.RegisterViewModel.NameIdentifier")?.Value;
        }

        public static string GetUserNameIdentifier(this IIdentity identity)
        {
            var claimsIdentity = identity as ClaimsIdentity;
            return claimsIdentity != null ? GetUserNameIdentifier(claimsIdentity) : "";
        }
    }
}