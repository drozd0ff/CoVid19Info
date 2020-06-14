﻿using System;
using CoVid19Info.Models;
using CoVid19Info.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoVid19Info.Services;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<AllCountriesModel>>> GetCountryModels()
        {
            //return await _context.AllCountriesModels.OrderByDescending(x => x.Cases).ToArrayAsync();

            return await i_context.AllCountriesModels.Where(x => DateTimeOffset.FromUnixTimeMilliseconds(x.Updated).Date == DateTime.Today).Select(x => x);
        }

        // GET: api/CountryModels/5
        //[HttpGet("{id}")]
        //public async void /*Task<ActionResult<CountryModel>>*/ GetCountryModel(int id)
        //{
        //if (id == 12)
        //{
        //    var request = WebRequest.Create("https://disease.sh/v2/countries/ukraine");
        //    StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());
        //    CountryModel countryModel = JsonConvert.DeserializeObject<CountryModel>(streamReader.ReadToEnd());

        //    _context.CountryModels.Add(countryModel);
        //    await _context.SaveChangesAsync();
        //}

        //var countryModel = await _context.CountryModels.FindAsync(id);

        //if (countryModel == null)
        //{
        //    return NotFound();
        //}

        //return countryModel;
        //}
    }
}