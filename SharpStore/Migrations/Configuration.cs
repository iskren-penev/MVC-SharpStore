namespace SharpStore.Migrations
{
    using System.Data.Entity.Migrations;
    using SharpStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SharpStore.Data.SharpStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SharpStore.Data.SharpStoreContext context)
        {
            context.Knives.AddOrUpdate(knife => knife.Name, new Knife[]
            {
                new Knife()
                {
                    Name = "Knife 3000",
                    Price = 99.99m,
                    ImageUrl = "http://www.topreviewpro.com/wp-content/uploads/2016/08/10.-Victorinox-47521-10-Inch-Chefs-Knife-Black-Fibrox-Handle-300x150.jpg"
                },
                new Knife()
                {
                    Name = "Sharp 1",
                    Price = 49.99m,
                    ImageUrl = "https://www.asamarketing.ie/images/pp/300/9c42f32fb93141139bd73e151de035761eedc86b.jpg"
                },
                new Knife()
                {
                    Name = "Sharpy 100",
                    Price = 199.99m,
                    ImageUrl = "http://www.hardwareretailing.com/wp-content/uploads/2015/05/KnifeFlashlight-300x150.jpg"
                },
            });
        }
    }
}
