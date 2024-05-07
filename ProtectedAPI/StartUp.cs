namespace ProtectedAPI
{
    public class StartUp
    {
        public IConfiguration Configuration { get; set; }

        public StartUp(IConfiguration configuration)
        {
            Configuration=configuration;
        }   

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddMvcOptions(options => options.EnableEndpointRouting = false);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler();
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
