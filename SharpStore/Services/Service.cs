namespace SharpStore.Services
{
    using SharpStore.Data;

    public abstract class Service
    {
        protected SharpStoreContext context;

        public Service(SharpStoreContext context)
        {
            this.context = context;
        }
    }
}
