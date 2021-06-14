using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPI.Web.DataAccess.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string SourceID { get; set; }
        public string SourceName { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string URLToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string content { get; set; }
        public int HeadlinesCategoryID { get; set; }
        public HeadlinesCategory HeadlinesCategory { get; set; }
    }
}
