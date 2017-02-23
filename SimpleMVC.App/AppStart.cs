namespace SharpStore
{
    using SimpleHttpServer;
    using SimpleMVC;

    class AppStart
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer(8181, RouteTable.Routes);
            MvcEngine.Run(server, "SharpStore");
        }
    }
}
