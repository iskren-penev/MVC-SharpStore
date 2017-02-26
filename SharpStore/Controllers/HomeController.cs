namespace SharpStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using SharpStore.BindingModels;
    using SharpStore.Services;
    using SharpStore.ViewModels;
    using SimpleHttpServer.Models;
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
        public IActionResult Contacts(MessageBindingModel model, HttpResponse response)
        {
            if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Subject))
            {
                Redirect(response, "/home/contacts");
            }
            MessageService service = new MessageService(Data.Data.Context);
            service.AddMessage(model);
            Redirect(response, "home/index");
            return null;
        }

        [HttpGet]
        public IActionResult<PurchaseViewModel> Buy(int knifeId, HttpResponse response)
        {
            PurchaseService service = new PurchaseService(Data.Data.Context);
            if (!service.IsKnifeIdValid(knifeId))
            {
                Redirect(response, "/home/index");
                return null;
            }
            
            return this.View(new PurchaseViewModel()
            {
                KnifeId = knifeId
            });
        }

        [HttpPost]
        public IActionResult Buy(PurchaseBindingModel model, HttpResponse response)
        {
            PurchaseService service = new PurchaseService(Data.Data.Context);
            service.AddPurchase(model);
            Redirect(response, "/home/index");
            return null;
        }
    }
}
