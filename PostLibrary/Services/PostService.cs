using PostLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLibrary.Services
{
    public class PostService : IPostService
    {
        private List<PostModel> PostsList;

        public PostService()
        {
            if(this.PostsList == null)
            {
                this.PostsList = new List<PostModel>();
                GenerateList();
            }
        }

        //completed
        public PostModel Add(PostModel model)
        {
            this.PostsList.Add(model);
            return model;
        }

        //completed
        public void Delete(int id)
        {
            PostsList.Remove(PostsList.Where(x => x.Id == id).FirstOrDefault());
        }

        public PostModel Edit(PostModel model)
        {
            PostModel newModel = model;
            this.PostsList.Remove(model);
            return newModel;
        }

        //completed
        public PostModel Get(int id)
        {
            return PostsList.Where(x => x.Id == id).FirstOrDefault();
        }

        //completed
        public List<PostModel> GetPosts()
        {
            return this.PostsList;
        }

        //completed
        private void GenerateList()
        {
            PostModel post = new PostModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 1,
                IsSticky = true,
                Message = "This is the first post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            PostsList.Add(post);
            PostModel post2 = new PostModel()
            {
                Id = 1,
                UserId = 1,
                Priority = 2,
                IsSticky = true,
                Message = "This is the second post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            PostsList.Add(post2);
            PostModel post3 = new PostModel()
            {
                Id = 3,
                UserId = 2,
                Priority = 1,
                IsSticky = true,
                Message = "This is the third post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            PostsList.Add(post3);
        }
    }
}
