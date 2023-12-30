using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Authentication
{
    public class JwtSettings
    {
        public const string SessionName = "JwtSettings";
        public string Secret { get; init; } = string.Empty;
        public int ExpiryMinutes { get; init; }
        public string Issuser { get; init; } = string.Empty;
        public string Audience { get; init; } = string.Empty;

    }
}
