using System;
using CoVid19Info.Models;
using CoVid19Info.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoVid19Info.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryModelsController : ControllerBase
    {
        private readonly DataContext _context;

        public CountryModelsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CountryModels
        [HttpGet]
        public ActionResult<IEnumerable<AllCountriesModel>> GetCountryModels()
        {
            //return await _context.AllCountriesModels.OrderByDescending(x => x.Cases).ToArrayAsync();

            var maxUpdated = _context.AllCountriesModels
                .Select(x => x.Updated)
                .Max();

            return _context.AllCountriesModels
                .AsEnumerable()
                .Where(x => DateTimeOffset.FromUnixTimeMilliseconds(x.Updated).Date == DateTimeOffset.FromUnixTimeMilliseconds(maxUpdated).Date)
                .OrderByDescending(x => x.Cases)
                .ToList();
        }
    }
}
