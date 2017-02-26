namespace SharpStore.Views.Home
{
    using System.IO;
    using SharpStore.ViewModels;
    using SimpleMVC.Interfaces;
    using SimpleMVC.Interfaces.Generic;

    public class Buy : IRenderable<PurchaseViewModel>
    {
        public string Render()
        {
            string htmlContent = File.ReadAllText("../../../content/buy.html");
            return string.Format(htmlContent, Model.ToString());
        }

        public PurchaseViewModel Model { get; set; }
    }
}
