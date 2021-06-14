using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NewsAPI.WebApi.Data.Model
{
    public partial class HeadLinesCategory
    {
        public HeadLinesCategory()
        {
            Articles = new HashSet<Articles>();
        }

        public int HeadlinesCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
