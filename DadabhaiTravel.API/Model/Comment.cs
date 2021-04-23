using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadabhaiTravel.Models
{
    public class Comment
    {
        public string postId { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}