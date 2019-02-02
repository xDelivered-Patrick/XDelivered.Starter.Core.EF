using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDelivered.StarterKits.NgCoreEF.Data;
using XDelivered.StarterKits.NgCoreEF.Modals;

namespace XDelivered.Starter.Core.EF.Website.Services.EntitiesService
{
    public class EntitiesService : IEntitiesService
    {
        private readonly ApplicationDbContext _dbContext;

        public EntitiesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<EntityModel> GetEntities()
        {
            var allEntities = _dbContext.Entities.ToList();
            return allEntities.Select(x => new EntityModel()
            {
                Id = x.Key.ToString(),
                Name = x.Name
            }).ToList();
        }
    }
}
