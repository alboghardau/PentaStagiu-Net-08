using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework08.Models
{
    public enum PostType { Text, Photo}

    public class PostViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime TimeOfPosting { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public PostType Type { get; set; }
        [Required]
        public bool IsSticky { get; set; }
        [Range(1,5)]
        public int Priority { get; set; }
    }
}