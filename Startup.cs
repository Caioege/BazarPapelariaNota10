using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using BazarPapelaria10.Database;
using BazarPapelaria10.Repositories.Contracts;
using BazarPapelaria10.Repositories;
using BazarPapelaria10.Bibliotecas.Sessao;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Bibliotecas.Middleware;
using Microsoft.Extensions.Hosting;
using BazarPapelaria10.Bibliotecas.Cookie;
using BazarPapelaria10.Bibliotecas.CarrinhoCompra;
using AutoMapper;
using BazarPapelaria10.Bibliotecas.AutoMapper;

namespace BazarPapelaria10
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
            //Session - Configuração
            services.AddHttpContextAccessor();

            services.AddMemoryCache(); //Guardar dados na memória
            services.AddSession(
                options =>
                {
                    options.Cookie.IsEssential = true;
                });
 
            services.AddScoped<Sessao>();
            services.AddScoped<BazarPapelaria10.Bibliotecas.Cookie.Cookie>();
            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();

            services.AddMvc(options =>
            {
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(x => "Esse campo não pode ser vazio.");
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //AUTOMAPPER
            var config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            //INTERFACES - PADRÃO REPOSITORY
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IImagemRepository, ImagemReporitory>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.AddScoped<BazarPapelaria10.Bibliotecas.Cookie.Cookie>();

            services.AddScoped<CarrinhoCompra>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

            services.AddDbContextPool<BazarPapelaria10Context>(options => options
                // CONNECTION STRING PARA O BANCO DE DADOS
                .UseMySql("Server=localhost;Database=bazarpapelarianota10efcore;User=root;Password=123456;", mySqlOptions => mySqlOptions
                    // VERSAO E TIPO DO BANCO
                    .ServerVersion(new Version(8, 0, 18), ServerType.MySql)
            ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
