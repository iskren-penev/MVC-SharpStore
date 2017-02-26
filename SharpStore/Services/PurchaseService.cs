namespace SharpStore.Services
{
    using System;
    using SharpStore.BindingModels;
    using SharpStore.Data;
    using SharpStore.Enums;
    using SharpStore.Models;

    class PurchaseService : Service
    {
        public PurchaseService(SharpStoreContext context) : base(context)
        {
        }

        public void AddPurchase(PurchaseBindingModel model)
        {
            Purchase purchase = new Purchase()
            {
                Name = model.Name,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                DeliveryType = (DeliveryType)Enum.Parse(typeof(DeliveryType), model.DeliveryType)
            };
            this.context.Purchases.Add(purchase);
            this.context.SaveChanges();
        }
        public bool IsKnifeIdValid(int knifeId)
        {
            return this.context.Knives.Find(knifeId) != null;
        }
    }
}
