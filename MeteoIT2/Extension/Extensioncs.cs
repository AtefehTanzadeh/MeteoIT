using MeteoIT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoIT2.Extension
{
    public static class Extensioncs
    {
        public static string GetFullName(this StationUsers user)
        {
            if (user == null) return string.Empty;

            return $"{user.FirstName} {user.LastName}".Trim();
        }
    }
}