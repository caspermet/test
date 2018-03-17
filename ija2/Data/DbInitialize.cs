using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ija2.Models;

namespace ija2.Data
{
    public static class DbInitialize
    {
        public static void Initialize(PhotosContext context)
        {
            context.Database.EnsureCreated();
            if (context.Photose.Any())
            {
                return;
            }
            var photos = new Photos[]
            {
                new Photos{Id=1,  Url="test", test="test2", test2="ahoj"},
            };
            foreach(var item in photos)
            {
                context.Photose.Add(item);
            }
            context.SaveChanges();
        }
    }
}
