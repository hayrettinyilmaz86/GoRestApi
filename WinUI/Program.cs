using Business.Abstract.User;
using Business.Concrete.Manager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WinUI.Forms.User;

namespace WinUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = new HostBuilder()
            .ConfigureServices((context, services) =>
            {
                ConfigureServices(context.Configuration, services);
            }).Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var mainForm = services.GetRequiredService<UserListForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            services.AddSingleton<UserListForm>();
            services.AddTransient<SaveUserForm>();
        }
    }
}
