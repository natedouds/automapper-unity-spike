using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using automapper_unity_spike.Models;
using AutoMapper;

namespace automapper_unity_spike.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public ValuesController(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET api/values
        public string Get()
        {
            StringBuilder strBuilder = new StringBuilder();
            _repo.Get().ForEach(v => strBuilder.Append(v));

            var person = new PersonBase
            {
                FirstName = "Bruce",
                LastName = "Wayne"
            };


            var hero = _mapper.Map<Superhero>(person);
            hero.SuperPower = "Batman";

            return $"{hero.FirstName} {hero.LastName} is {hero.SuperPower}!";
        }
    }
}
