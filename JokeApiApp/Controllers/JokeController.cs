using JokeApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JokeApiApp.Controllers
{
    public class JokeController : Controller
    {
        private readonly JokeService jokeService = new JokeService();
        public async Task<ActionResult> Index()
        {
            var joke = await jokeService.GetRandomJokeAsync();
            return View(joke);
        }

    }
}