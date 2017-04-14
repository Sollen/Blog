using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class ArticleRating
    {
        [Key]
        public int RatingID { get; set; }               
        public int ValueRating { get; set; }
        public Article ArticleID { get; set; }

    }
}