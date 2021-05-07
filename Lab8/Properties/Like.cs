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

           User users = (from user in context.User where user.Name == Name select user).SingleOrDefault();
            string count = "";
            string count_before = "";
            if (users != null)
            {
                count_before = users.Likes.ToString();
                users.Likes++;
                context.SaveChanges();
                count = $"Likes before:{count_before} You liked! Num likes now:{users.Likes}";
                return count;
            }
            else
            {
                context.User.Add(new User()
                {
                    Name = Name,
                    Likes = 1
                });
                context.SaveChanges();
                count = $"It is a new user! You liked! Num likes now:1";
                return count;
            }

        }

    }
}
