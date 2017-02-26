namespace SharpStore.Services
{
    using SharpStore.BindingModels;
    using SharpStore.Data;
    using SharpStore.Models;

    public class MessageService : Service
    {
        public MessageService(SharpStoreContext context) : base(context)
        {
        }

        public void AddMessage(MessageBindingModel model)
        {
            Message message = new Message()
            {
                Sender = model.Email,
                Subject = model.Subject,
                Content = model.Message
            };
            this.context.Messages.Add(message);
            this.context.SaveChanges();

        }
    }
}
