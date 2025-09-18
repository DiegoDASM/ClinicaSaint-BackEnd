using AutoMapper;
using ClinicaSaint.API.Controllers.Catalogos;
using ClinicaSaint.Domain.Common;
using ClinicaSaint.Domain.Interfaces.Catalogos;
using ClinicaSaint.Domain.Interfaces.Reserva;
using ClinicaSaint.Infrestructura;
using ClinicaSaint.Infrestructura.Repositorios.Catalogos;
using ClinicaSaint.Infrestructura.Repositorios.Reserva;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

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
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClinicaSaint API", Version = "v1" });

                c.CustomSchemaIds(type => type.FullName?.Replace("+", "."));

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                {
                    c.IncludeXmlComments(xmlPath);
                }
            });

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddScoped<IReservaConsultaRepository, ReservaConsultaRepository>();
            builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
            builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ClinicaSaint API v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
