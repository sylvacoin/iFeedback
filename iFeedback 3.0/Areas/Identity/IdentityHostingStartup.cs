using System;
using iFeedback.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(iFeedback.Areas.Identity.IdentityHostingStartup))]
namespace iFeedback.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<AppDBContext>(option =>
                //option.UseSqlServer(context.Configuration.GetConnectionString('AppDbContextConnection')));
            });
        }
    }
}