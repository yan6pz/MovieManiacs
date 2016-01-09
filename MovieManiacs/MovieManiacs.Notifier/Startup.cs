using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Hangfire;

[assembly: OwinStartup(typeof(MovieManiacs.Notifier.Startup))]

namespace MovieManiacs.Notifier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configuration.UseSqlServerStorage("MovieManiacsDBAdoNet");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
