using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cleanarchitecture_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        private ISender? _sender;

        protected ISender Sender => _sender ??= HttpContext.RequestServices.GetRequiredService<ISender>(); 
    }
}
