using BookCRUD.Data;
using BookCRUD.Repositories;
using BookCRUD.Services;
using Microsoft.EntityFrameworkCore;


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(connectionString));


            // inject the services in Project

            builder.Services.AddScoped<IBookRepo,BookRepo>();
            builder.Services.AddScoped<IBookService,BookService>();





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
