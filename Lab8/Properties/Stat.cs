using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class Stat : ControllerBase

    {  
        public static Context context = new Context();
        [HttpGet]
          public List<string> Get()
        {
            List<string> spisok = new List<string>();

            IQueryable<User> user = from us in context.User select us;
            foreach (User users in user)
                spisok.Add($"Name: {users.Name}, Likes: {users.Likes}");
            // list.Add(new User() { Name = users.Name, Likes = users.Likes });
            return spisok;

        }

    }
}
