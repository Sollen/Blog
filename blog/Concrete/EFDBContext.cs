﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebUI.Models;


namespace WebUI.Concrete
{
    public class EFDBContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleRating> ArticleRatings { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
    }
}