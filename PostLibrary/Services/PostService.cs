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
            try
            {
                this.PostsList = XMLWriter.ReadFromXmlFile<List<PostModel>>("posts.xml");
                if (this.PostsList == null || this.PostsList.Count() == 0)
                {
                    this.PostsList = GenerateList();
                }
            }
            catch (Exception e)
            {
                this.PostsList = GenerateList();
                Console.WriteLine("###FAILED TO LOAD XML DATA!###");
                Console.WriteLine(e.Message.ToString());
            }
        }

        //SAVE XML DATA IN DESTRUCTOR
        ~PostService()
        {
            SaveData();
        }


        private void SaveData()
        {
            XMLWriter.WriteToXmlFile("posts.xml", this.PostsList);
        }

        //completed
        public PostModel Add(PostModel model)
        {
            model.Id = MaxId() + 1; 
            this.PostsList.Add(model);
            SaveData();
            return model;
        }

        //completed
        public void Delete(int id)
        {
            PostsList.Remove(PostsList.Where(x => x.Id == id).FirstOrDefault());
            SaveData();
        }

        public PostModel Edit(PostModel newModel)
        {
            int index = this.PostsList.FindIndex(x => x.Id == newModel.Id);
            if (index >= 0)
            {
                this.PostsList[index] = newModel;
            }
            SaveData();
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
        private List<PostModel> GenerateList()
        {
            List<PostModel> posts = new List<PostModel>();
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
            posts.Add(post);
            PostModel post2 = new PostModel()
            {
                Id = 2,
                UserId = 1,
                Priority = 2,
                IsSticky = true,
                Message = "This is the second post",
                Type = PostType.Photo,
                TimeOfPosting = DateTime.Now
            };
            posts.Add(post2);
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
            posts.Add(post3);
            return posts;
        }

        private int MaxId()
        {
            return this.PostsList.Max(t => t.Id);
        }
    }
}
