using Microsoft.AspNetCore.Antiforgery;
using Mellowood.Controllers;

namespace Mellowood.Web.Host.Controllers
{
    public class AntiForgeryController : MellowoodControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
