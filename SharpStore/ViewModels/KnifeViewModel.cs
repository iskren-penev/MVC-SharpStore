﻿namespace SharpStore.ViewModels
{
    public class KnifeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            string template = "<div class=\"col-sm-4\">\r\n" +
                              $"<img class=\"img-thumbnail\" src=\"{this.Url}\">\r\n" +
                              $"<h3>{this.Name}</h3>\r\n" +
                              $"<p>${this.Price:F2}</p>\r\n" +
                              $"<a href=\"/home/buy?knifeId={this.Id}\" class=\"btn btn-primary\" role=\"button\">Buy Now</a>\r\n" +
                              "</div>";
            return template;
        }
    }
}
