//using System;
//using IdentityAssgnmnt.Areas.Identity.Data;
//using IdentityAssgnmnt.Data;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//[assembly: HostingStartup(typeof(IdentityAssgnmnt.Areas.Identity.IdentityHostingStartup))]
//namespace IdentityAssgnmnt.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        //public void Configure(IWebHostBuilder builder)
//        //{
//        //    builder.ConfigureServices((context, services) => {
//        //        services.AddDbContext<ApplicationDbContext>(options =>
//        //            options.UseSqlServer(
//        //                context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

//        //        services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
//        //            .AddEntityFrameworkStores<ApplicationDbContext>();
//        //    });
//        //}
//    }
//}