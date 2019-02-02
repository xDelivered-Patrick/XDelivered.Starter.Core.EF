using System;

namespace XDelivered.StarterKits.NgCoreEF.Modals
{
    public class LoginResponse
    {
        public DateTime Expiration { get; set; }
        public string Token { get; set; }
    }
}