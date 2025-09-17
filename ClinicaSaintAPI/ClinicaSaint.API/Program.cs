
using AutoMapper;
using ClinicaSaint.Domain.Common;
using ClinicaSaint.Domain.Interfaces.Reserva;
using ClinicaSaint.Infrestructura;
using ClinicaSaint.Infrestructura.Repositorios.Reserva;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicaSaint.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddAutoMapper(config => config.AddProfile<MappingProfile>());

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            var AllowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins(AllowedOrigins ?? Array.Empty<string>())
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });


            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddScoped<IReservaConsultaRepository, ReservaConsultaRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
