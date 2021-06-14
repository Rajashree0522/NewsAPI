using NewsAPI.WebApi.Data.Access.DAL;
using NewsAPI.WebApi.Data.Model;
using NewsAPI.WebApi.Queries.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAPI.WebApi.Queries.Repositories
{
    public class ArticleQueryProcessor : IArticleQueryProcessor
    {
        NewsAPIOrgContext context = new NewsAPIOrgContext();

        public List<Articles> Get()
        {
            return context.Articles.ToList();
        }

        public Articles Get(int id)
        {
            return context.Articles.Where(a => a.ArticleId == id).SingleOrDefault();
        }

        public List<Articles> GetByCategory(int headlinesCategoryId)
        {
            return context.Articles.Where(a => a.HeadlinesCategoryId == headlinesCategoryId).OrderByDescending(a => a.PublishedAt).Take(20).ToList();
        }
    }
}
