using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UsingEFMVCwebAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public bool IsAnonymous { get; set; }

        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}