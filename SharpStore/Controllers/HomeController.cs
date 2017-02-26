namespace SharpStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using SharpStore.BindingModels;
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
        public IActionResult<IEnumerable<KnifeViewModel>> Products(string productName)
        {
            if (productName == null)
            {
                productName = String.Empty;
            }
            KnifeService service = new KnifeService(Data.Data.Context);
            var viewModels = service.GetProducts(productName);
            return this.View(viewModels);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Contacts(MessageBindingModel model)
        {
            MessageService service = new MessageService(Data.Data.Context);
            service.AddMessage(model);

            return this.View();
        }
    }
}
