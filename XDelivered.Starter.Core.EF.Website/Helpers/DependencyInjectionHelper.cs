using System;
using Microsoft.Extensions.DependencyInjection;

namespace XDelivered.StarterKits.NgCoreEF.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static IServiceScope ServiceScope { get; set; }
        public static IServiceProvider ApplicationServices { get; set; }
    }
}