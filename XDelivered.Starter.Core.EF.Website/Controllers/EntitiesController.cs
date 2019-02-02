using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using XDelivered.Starter.Core.EF.Website.Services.EntitiesService;
using XDelivered.StarterKits.NgCoreEF.Modals;

namespace XDelivered.StarterKits.NgCoreEF.Controllers
{

    [Route("api/entities")]
    [Authorize]
    [ApiController]
    [Produces("application/json")]
    public class EntitiesController : Controller
    {
        private readonly IEntitiesService _entitiesService;

        public EntitiesController(IEntitiesService entitiesService)
        {
            _entitiesService = entitiesService;
        }

        [HttpGet("")]
        [Produces(typeof(OperationResult<List<EntityModel>>))]
        [SwaggerOperation(nameof(AllEntities))]
        public List<EntityModel> AllEntities()
        {
            return _entitiesService.GetEntities();
        }
    }
}