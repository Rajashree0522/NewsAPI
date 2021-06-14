using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPI.Web.DataAccess.Models
{
    public class HeadlinesCategory
    {
        public int HeadlinesCategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
