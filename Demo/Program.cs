
            var webApplicationBuilder = WebApplication.CreateBuilder();

            #region Configure Services 
            webApplicationBuilder.Services.AddControllersWithViews();
            #endregion

            var App = webApplicationBuilder.Build();

            #region Configure 


            if (App.Environment.IsDevelopment())
            {
                App.UseDeveloperExceptionPage();//MiddleWAre
            }
            else
            {
                App.UseStatusCodePagesWithReExecute("/Home/Error");
            }
            App.UseRouting();

            App.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello world!");
            });

            App.MapPost("/Hamada", async context =>
            {
                await context.Response.WriteAsync("Hello Hamada!");
            });


            App.MapControllerRoute(
                name: "default",
                pattern: "{Controller}/{action}/{id?}"

                );
            #endregion

            App.Run();




 
