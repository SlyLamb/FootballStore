﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballStore.Startup))]
namespace FootballStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
