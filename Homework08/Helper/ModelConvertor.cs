using Homework08.Models;
using PostLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework08.Helper
{
    public class ModelConvertor
    {
        public static PostViewModel ModelToViewModel(PostModel post)
        {

            return new PostViewModel
            {
                Id = post.Id,
                IsSticky = post.IsSticky,
                Message = post.Message,
                Priority = post.Priority,
                TimeOfPosting = post.TimeOfPosting,
                Type = post.Type,
                UserId = post.UserId
                
            };
        }

        public static PostModel ViewModelToModel(PostViewModel post)
        {
            return new PostModel
            {
                IsSticky = post.IsSticky,
                Message = post.Message,
                Priority = post.Priority,
                TimeOfPosting = post.TimeOfPosting,
                Type = post.Type,
                UserId = post.UserId
            };
        }
    }
}