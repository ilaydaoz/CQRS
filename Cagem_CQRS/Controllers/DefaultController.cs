using Cagem_CQRS.Cqrs.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Cagem_CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        public DefaultController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }
        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handler();
            return View(values);
        }
    }
}
