using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Code_Challenge_2_que.Repositry;
using MVC_Code_Challenge_2_que.Models;
using MVC_Code_Challenge_2_que.Controllers;

namespace MVC_Code_Challenge_2_que.Repositry
{
    interface IMovieRespositry
    {

            IEnumerable<Movies> GetAll();
            Movies GetById(int id);
            void Insert(Movies movie);
            void Update(Movies movie);
            void Save();
        }
}

