using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController:Controller
    {
        //Action ==>Public nonstatic Object Member Method inside the Controller 
        [HttpGet] //baseUrl/Movies/Index
        [ActionName("Index")]
        public string GetAllMovie()
        {
            return "All Movies";
        }
        [HttpGet] //baseUrl/Movies/GetMovie/{id}?name=Avatar
        public string GetMovie(int id,string name )
        {
            return $"Movie with id : {id} And Name :{name}";
        }

        public ViewResult CreateMovie()
        {
            return View();  
        }
        [ActionName("ConfirmCreateMovie")]
        public OkResult CreateMovie(Movie movie)
        {
            return Ok();
        }
    }
}
