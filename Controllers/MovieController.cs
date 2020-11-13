using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

using SPA.BusinessModels;
using SPA.Models;


namespace SPA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {

            _logger = logger;
        }

        [HttpGet]
        //[Route("GetMovies")]
        public async Task<IActionResult> GetMovies()
        {
            var sample = @"[{
                ""ProjectId"": 9999,
                ""title"": ""not implemented"",
                ""releaseYear"": -1,
                ""gerne"": """",
                ""greenlit"": false,
                ""aspectRatio"": """"
                }]";

            return Ok(sample);
        }

        [HttpPut] //idempotent
        public async Task<IActionResult> Update([FromBody] Movie movie)
        {
            //find the movie in the project table
            using (var context = new MoviesContext())
            {
                return null;
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Movie movie)
        {
            return _save(movie);
        }

        private IActionResult _save(Movie movie)
        {
            return null;


        }
    }
}
