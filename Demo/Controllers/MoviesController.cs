using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController:Controller
    {

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

        /// private readonly IConfiguration _configuration;
        /// public MoviesController(IConfiguration configuration)
        /// {
        ///     _configuration = configuration;
        /// }
        /// 
        public IConfiguration Configuration { get; }
        public MoviesController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IActionResult GetMovie([FromHeader]int id,string name )

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

        [HttpGet]
        public IActionResult CreateMovie([FromServices]IConfiguration configuration)
        {
            return View();

        }
        [HttpPost]

        public IActionResult CreateMovie(Movie movie)
        {
            return Ok();
        }


    }
}
