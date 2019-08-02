using ImportacaoPreco.Aplicacao;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Persistence;
using ImportacaoPreco.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImportacaoPreco.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<Produto>), typeof(ProdutoRepository));
            services.AddScoped(typeof(IRepository<Grupo>), typeof(Repository<Grupo>));

            services.AddScoped(typeof(IEntityService<Produto, ProdutoDto>), typeof(ProdutoService));
            services.AddScoped(typeof(IEntityService<Grupo, GrupoDto>), typeof(GrupoService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
