using NewsAPI.Web.DataAccess.Data;
using NewsAPI.Web.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAPI.Web.Business.BusinessLayer
{
    public class ArticleBusiness
    {
        public void CreateNews(List<Article> article,ApplicationDbContext context)
        {
            context.Articles.AddRange(article);
            context.SaveChanges();
        }
    }
}
