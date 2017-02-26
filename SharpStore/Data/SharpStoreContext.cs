namespace SharpStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SharpStore.Models;

    public class SharpStoreContext : DbContext
    {
        public SharpStoreContext()
            : base("SharpStoreContext")
        {
        }

        public DbSet<Knife> Knives { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
    
}