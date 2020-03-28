using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLibrary
{
    public enum PostType { Text, Photo }
    public class PostModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public string Message { get; set; }
        public PostType Type { get; set; }
        public bool IsSticky { get; set; }
        public int Priority { get; set; }
    }
}
