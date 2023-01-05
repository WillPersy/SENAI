using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Chapter.DevApi
{
    public class Startup
    {
        // Chamado pelo host antes do m�todo Configure para configurar os servi�os do aplicativo.
        public void ConfigureServices(IServiceCollection services)
        {
            // adiciona os servi�os necess�rios para 
            services.AddControllers();
            // a cada solicita��o, uma nova inst�ncia � criada
            services.AddTransient<LivroRepository, LivroRepository>();
            // configura o swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChapterApi", Version = "v1" });
            });
            // Adiciona o CORS ao projeto
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => {
                        builder.WithOrigins("*")
                                                                    .AllowAnyHeader()
                                                                    .AllowAnyMethod();
                    }
                );
            });
        }

        // O m�todo Configure � usado para especificar como o aplicativo responde �s solicita��es HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // ativa o middleware para uso do swagger
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChapterApi v1"));
            }

            app.UseRouting();

            // Habilita o CORS
            app.UseCors("CorsPolicy");

            // mapear os controller
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
