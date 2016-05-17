using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Http;
using ThorsHammerPoC.Models;

namespace ThorsHammerPoC.Controllers
{
    [System.Web.Mvc.RoutePrefix("api/Mjolnir/{count}")]
    public class MjolnirController : ApiController
    {
        [HttpGet]
        public UserDto Get(string count)
        {
            int Count = Int32.Parse(count);
            if (Count > 100)
            {
                //throw exception randomly
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(0, 10);
                if (randomNumber%2 == 0)
                {
                    throw new Exception();
                }
            }
            return new UserDto(Count, "test");
        }
    }
}