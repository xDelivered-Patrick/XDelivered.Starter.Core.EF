using System.Collections.Generic;
using XDelivered.StarterKits.NgCoreEF.Modals;

namespace XDelivered.Starter.Core.EF.Website.Services.EntitiesService
{
    public interface IEntitiesService
    {
        List<EntityModel> GetEntities();
    }
}