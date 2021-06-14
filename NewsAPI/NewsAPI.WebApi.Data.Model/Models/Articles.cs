using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NewsAPI.WebApi.Data.Model
{
    public partial class Articles
    {
        public int ArticleId { get; set; }
        public string SourceId { get; set; }
        public string SourceName { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrltoImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
        public int HeadlinesCategoryId { get; set; }

        public virtual HeadLinesCategory HeadlinesCategory { get; set; }
    }
}
