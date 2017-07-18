using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class ArticleComment
    {
        [Key]
        public int CommentID { get; set; }
        public string Text { get; set; }
        public Article ArticleID { get; set; }
        public int ParrentComment { get; set; }
        public int Rating { get; set; }
        public DateTime CreateDate { get; set; }
    }
}