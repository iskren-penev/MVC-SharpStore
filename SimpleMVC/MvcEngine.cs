namespace SimpleMVC
{
    using System;
    using System.Reflection;
    using SimpleHttpServer;

    public static class MvcEngine
    {
        public static void Run(HttpServer server, string applicationAssemblyName)
        {
            RegisterAssemblyName(applicationAssemblyName);
            RegisterControllers();
            RegisterViews();
            RegisterModels();
            LoadAssembly(applicationAssemblyName);

            try
            {
                server.Listen();
            }
            catch (Exception e)
            {
                //Log errors
                Console.WriteLine(e.Message);
            }
        }

        private static void LoadAssembly(string applicationAssemblyName)
        {
            MvcContext.Current.AplicationAssembly = Assembly.Load(applicationAssemblyName);
        }

        private static void RegisterAssemblyName(string applicationAssemblyName)
        {
            MvcContext.Current.AssemblyName = applicationAssemblyName;

        }

        private static void RegisterControllers()
        {
            MvcContext.Current.ControllersFolder = "Controllers";
            MvcContext.Current.ControllersSuffix = "Controller";
        }

        private static void RegisterViews()
        {
            MvcContext.Current.ViewsFolder = "Views";
        }

        private static void RegisterModels()
        {
            MvcContext.Current.ModelsFolder = "Models";
        }
    }
}
