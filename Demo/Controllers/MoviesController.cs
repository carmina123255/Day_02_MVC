using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController:Controller
    {
        private readonly IConfiguration _configuration;

        //Action ==>Public nonstatic Object Member Method inside the Controller 

        #region Routing 
        /// [HttpGet] //baseUrl/Movies/Index
        /// [ActionName("Index")]
        /// public string GetAllMovie()
        /// {
        ///     return "All Movies";
        /// }
        /// [HttpGet] //baseUrl/Movies/GetMovie/{id}?name=Avatar
        /// public string GetMovie(int id,string name )
        /// {
        ///     return $"Movie with id : {id} And Name :{name}";
        /// }
        ///
        /// public ViewResult CreateMovie()
        /// {
        ///     return View();  
        /// }
        /// [ActionName("ConfirmCreateMovie")]
        /// public OkResult CreateMovie(Movie movie)
        /// {
        ///     return Ok();
        /// }
        ///  
        #endregion

        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public IActionResult GetMovie(int id)

        {
            if (id == 0) return BadRequest();             // return new BadRequestResult();
            else if (id == 100) return NotFound();        //return new NotFoundResult();
            else
            {
                /// ContentResult result = new ContentResult();
                /// result.Content = $"Movie with id : {id}";
                /// result.ContentType = "text/html";
                /// result.StatusCode = 200;
                /// 
                /// return result;
                /// 
                return Content($"Movie with id : {id}", "text/html");
            }

        }

        public IActionResult Kermina()
        {
          /// RedirectResult result = new RedirectResult("https://wuzzuf.net/jobs/egypt");
          /// RedirectResult result = new RedirectResult(_configuration["WuzzufUrl"]??string.Empty);
          /// RedirectResult result = new RedirectResult($"{_configuration["MovieUrl"]}/Movies/GetMovie/10");
          /// return result;


            /// RedirectToActionResult result = new RedirectToActionResult(nameof(GetMovie),"Movies", new {id=10});
            ///      return result;



           /// RedirectToRouteResult result = new RedirectToRouteResult("default", new { Controller = "Movies", action = "GetMovie", id = 10 });
           ///
           /// return result;


            return Redirect("https://wuzzuf.net/jobs/egypt");
        }
    }
}
