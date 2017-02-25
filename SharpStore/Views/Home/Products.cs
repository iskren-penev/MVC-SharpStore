namespace SharpStore.Views.Home
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using SharpStore.ViewModels;
    using SimpleMVC.Interfaces;
    using SimpleMVC.Interfaces.Generic;

    public class Products : IRenderable<IEnumerable<KnifeViewModel>>
    {
        public string Render()
        {
            string html = File.ReadAllText("../../../content/products.html");
            StringBuilder sb = new StringBuilder();
            foreach (KnifeViewModel model in Model)
            {
                sb.Append(model.ToString());
            }
            return string.Format(html, sb);
        }

        public IEnumerable<KnifeViewModel> Model { get; set; }
    }
}
