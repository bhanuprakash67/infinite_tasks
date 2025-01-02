using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Code_Challenge_2_que.Models
{
    public class Movies
    {
            [Key]
            public int Mid { get; set; }

            public string Moviename { get; set; }
            public DateTime DateofRelease { get; set; }
        }
        
    }