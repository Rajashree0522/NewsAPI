using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsAPI.Web.Business.BusinessLayer;
using NewsAPI.Web.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsAPI.Web.Controllers
{
    public class ArticleController : Controller
    {
        ArticleBusiness articleBusiness = new ArticleBusiness();
        private readonly ApplicationDbContext _context;
        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetData()
        {
            return View();
        }
        [Authorize]
        public IActionResult CreateTopHeadlines()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();
               
                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = -1
                    
                }).ToList();

                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateBusiness()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Business
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 1
                }).ToList();

                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateEntertainment()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Entertainment
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 2
                }).ToList();
                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateHealth()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Health
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 3
                }).ToList();
                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateScience()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Science
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 4
                }).ToList();
                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateSports()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Sports
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 5
                }).ToList();
                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
        [Authorize]
        public IActionResult CreateTechnology()
        {
            var newsApiClient = new NewsApiClient("75a24814896d49c1b9fecced4d5fc163");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                PageSize = 20,
                Language = Languages.EN,
                Category = Categories.Technology
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                List<NewsAPI.Web.DataAccess.Models.Article> articles = new List<NewsAPI.Web.DataAccess.Models.Article>();

                articles = articlesResponse.Articles.Select(a => new NewsAPI.Web.DataAccess.Models.Article
                {
                    Author = a.Author,
                    SourceID = a.Source.Id,
                    SourceName = a.Source.Name,
                    Title = a.Title,
                    PublishedAt = (DateTime)a.PublishedAt,
                    URL = a.Url,
                    URLToImage = a.UrlToImage,
                    content = a.Content,
                    Description = a.Description,
                    HeadlinesCategoryID = 6
                }).ToList();
                articleBusiness.CreateNews(articles, _context);
            }
            ViewBag.showAlert = true;
            return View("GetData");
        }
    }
}
