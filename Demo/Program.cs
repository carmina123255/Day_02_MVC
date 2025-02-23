
using Microsoft.AspNetCore.Routing.Constraints;

var webApplicationBuilder = WebApplication.CreateBuilder();

            #region Configure Services 
            webApplicationBuilder.Services.AddControllersWithViews();  //Register MVC Required
           /// webApplicationBuilder.Services.AddControllers();            //Register API Required
           /// webApplicationBuilder.Services.AddRazorPages();            //Register Razor page Required
           /// webApplicationBuilder.Services.AddMvc();                   // Register API,MVC and Razor Page Required
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
     App.UseStaticFiles();

           /// App.MapGet("/", async context =>
           /// {
           ///     await context.Response.WriteAsync("Hello world!");
           /// });

          ///   App.MapGet("/XX{id:int}", async context =>
          ///   {
          ///       await context.Response.WriteAsync($"Id = {context.Request.RouteValues["id"]}");
          ///   });
          ///
          ///  App.MapPost("/Hamada", async context =>
          ///  {
          ///      await context.Response.WriteAsync("Hello Hamada!");
          ///  });
          ///

           App.MapControllerRoute(
               name: "default",
               pattern: "{Controller=Home}/{action=Index}/{id:int?}/{name:alpha?}"
              // ,defaults: new { Controller = "Movies" ,action ="Index" },
             // constraints: new { id = new IntRouteConstraint() }
               );
#endregion

App.Run();




 
