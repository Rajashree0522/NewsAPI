using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsAPI.WebApi.Business.BAL;
using NewsAPI.WebApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPI.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetTopHeadlines",Name = "GetTopHeadlines")]
        public List<Articles> GetTopHeadlines()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(-1);
            return articles;
        }

        [HttpGet("Getbusiness", Name = "GetBusinessNews")]
        public List<Articles> GetBusinessNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(1);
            return articles;
        }

        [HttpGet("Getentertainment", Name = "GetEntertainmentNews")]
        public List<Articles> GetEntertainmentNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(2);
            return articles;
        }

        [HttpGet("Gethealth", Name = "GetHealthNews")]
        public List<Articles> GetHealthNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(3);
            return articles;
        }

        [HttpGet("Getscience", Name = "GetScienceNews")]
        public List<Articles> GetScienceNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(4);
            return articles;
        }

        [HttpGet("Getsports", Name = "GetSportsNews")]
        public List<Articles> GetSportsNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(5);
            return articles;
        }

        [HttpGet("Gettechnology", Name = "GetTechnologyNews")]
        public List<Articles> GetTechnologyNews()
        {
            ArticleBusiness articleBusiness = new ArticleBusiness();
            var articles = articleBusiness.GetArticlesByCategoryID(6);
            return articles;
        }
    }
}

