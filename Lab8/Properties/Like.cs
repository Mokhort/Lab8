using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8.Properties
{
    //http://localhost:5000/api/Like?Name=Moxe
    [Route("api/[controller]")]
    [ApiController]
    public class Like : ControllerBase
    {
        [HttpGet]
        public string Get(string Name) {
            Context context = new Context();

            IQueryable<User> users = from user in context.User where user.Name == Name select user;
            string count = "";
            foreach (User user2 in users)
                count = user2.Likes.ToString();
            return count;
        }

    }
}
