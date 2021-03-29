using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerApi.Models;

namespace ServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController:ControllerBase
    {
        protected readonly DataContext ctx;     
        public BaseController( DataContext data){          
            ctx=data;
        }
    }
}