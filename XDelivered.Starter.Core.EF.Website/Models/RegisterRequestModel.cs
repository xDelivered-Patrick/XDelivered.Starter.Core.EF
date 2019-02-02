using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDelivered.StarterKits.NgCoreEF.Helpers;

namespace XDelivered.StarterKits.NgCoreEF.Modals
{
    public class RegisterRequestModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}
