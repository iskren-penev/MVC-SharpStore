﻿namespace SharpStore.Views.Home
{
    using System.IO;
    using SimpleMVC.Interfaces;
    public class About : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../../content/about.html");
        }
    }
}
