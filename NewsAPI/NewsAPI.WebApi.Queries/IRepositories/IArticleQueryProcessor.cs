using NewsAPI.WebApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAPI.WebApi.Queries.IRepositories
{
    public interface IArticleQueryProcessor
    {
        List<Articles> Get();
        Articles Get(int id);
        List<Articles> GetByCategory(int headlinesCategoryId);
    }
}
