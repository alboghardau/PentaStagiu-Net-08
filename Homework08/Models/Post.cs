using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework08.Models
{
    enum PostType { Text, Photo}
    public class Post
    {
        int Id;
        int UserId;
        DateTime TimeOfPosting;
        string Message;
        PostType Type;
        bool IsSticky;
        int Priority;
    }
}