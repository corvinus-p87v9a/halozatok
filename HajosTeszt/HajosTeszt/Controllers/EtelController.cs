using HajosTeszt.Etelek;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    namespace HajosTeszt.Controllers
    {
    [Route("api/etelek")]
    [ApiController]
    public class EtelController : ControllerBase
    {
        // GET: api/<EtelController>
        [HttpGet]
        public IEnumerable<P87v9a> Get()
        {
            SzamhaloContext context = new SzamhaloContext();
            return context.P87v9as.ToList();
        }

        // GET api/<EtelController>/5
        [HttpGet("{id}")]
        public P87v9a Get(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var keresettEtel = (from x in context.P87v9as
                                where x.Id == id
                                select x).FirstOrDefault();
            return keresettEtel;
        }

        // POST api/<EtelController>
        [HttpPost]
        public void Post([FromBody] P87v9a ujEtel)
        {
            SzamhaloContext context = new SzamhaloContext();
            context.P87v9as.Add(ujEtel);
            context.SaveChanges();
        }

        // PUT api/<EtelController>/5
        [HttpGet("{id}")]
        [Route("etelek/count")]
        public int etelSzam()
        {
            SzamhaloContext context = new SzamhaloContext();
            int etelSzam = context.P87v9as.Count();
            return etelSzam;
        }

        //DELETE api/<EtelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var törlendőétel = (from x in context.P87v9as
                                where x.Id == id
                                select x).FirstOrDefault();

                context.Remove(törlendőétel);



            context.SaveChanges();
        }
    }

    }
    

