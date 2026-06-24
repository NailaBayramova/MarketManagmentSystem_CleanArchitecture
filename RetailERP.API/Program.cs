
//namespace RetailERP.API
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container.

//            builder.Services.AddControllers();
//            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//            builder.Services.AddOpenApi();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if (app.Environment.IsDevelopment())
//            {
//                app.MapOpenApi();
//            }

//            app.UseHttpsRedirection();

//            app.UseAuthorization();


//            app.MapControllers();

//            app.Run();
//        }
//    }
//}

using Microsoft.EntityFrameworkCore;                  // <--- BU ƏLAVƏ OLUNDU
using RetailERP.Persistence.Context;
using RetailERP.Persistence.Context;                 // <--- BU ƏLAVƏ OLUNDU

namespace RetailERP.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Verilənlər Bazası (PostgreSQL) Qeydiyyatı buraya yazılır:
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // <--- BU ƏLAVƏ OLUNDU

            // Add services to the container.
            builder.Services.AddControllers();

            // .NET 9-un öz daxili OpenAPI (Swagger əvəzedicisi) servisi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                // .NET 9-da render olan OpenAPI JSON sənədi
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}