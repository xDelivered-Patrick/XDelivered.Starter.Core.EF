﻿using System;
using Microsoft.AspNetCore.Identity;

namespace XDelivered.StarterKits.NgCoreEF.Data
{
    public class User : IdentityUser
    {
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
