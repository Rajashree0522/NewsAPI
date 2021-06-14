using NewsAPI.WebApi.Data.Model;
using NewsAPI.WebApi.Queries.IRepositories;
using NewsAPI.WebApi.Queries.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAPI.WebApi.Business.BAL
{
    public class ArticleBusiness
    {
        IArticleQueryProcessor articleQueryProcessor;
        public ArticleBusiness()
        {
            articleQueryProcessor = new ArticleQueryProcessor();
        }

        public List<Articles> GetArticlesByCategoryID(int id)
        {
            var articles = articleQueryProcessor.GetByCategory(id);
            return articles;
        }
    }
}
