namespace SharpStore.Controllers
{
    using System.Collections.Generic;
    using SharpStore.Services;
    using SharpStore.ViewModels;
    using SimpleMVC.Attributes.Methods;
    using SimpleMVC.Controllers;
    using SimpleMVC.Interfaces;
    using SimpleMVC.Interfaces.Generic;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult<IEnumerable<KnifeViewModel>> Products()
        {
            KnifeService service = new KnifeService(Data.Data.Context);
            var viewModels = service.GetProducts();
            return this.View(viewModels);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return this.View();
        }
    }
}
