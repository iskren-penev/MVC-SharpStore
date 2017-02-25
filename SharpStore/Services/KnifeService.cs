﻿namespace SharpStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using SharpStore.Data;
    using SharpStore.Models;
    using SharpStore.ViewModels;

    public class KnifeService : Service
    {
        public KnifeService(SharpStoreContext context) 
            : base(context)
        {
        }

        public IEnumerable<KnifeViewModel> GetProducts()
        {
            List<KnifeViewModel> viewModels = new List<KnifeViewModel>();
            List<Knife> knives = this.context.Knives.ToList();
            foreach (Knife knife in knives)
            {
                viewModels.Add(new KnifeViewModel()
                {
                    Name = knife.Name,
                    Price = knife.Price,
                    Url = knife.ImageUrl
                });
            }

            return viewModels;
        }
    }
}