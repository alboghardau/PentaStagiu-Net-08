using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLibrary.Interfaces
{
    public interface IPostService
    {
        List<PostModel> GetPosts();
        PostModel Get(int id);
        PostModel Add(PostModel model);
        PostModel Edit(PostModel model);
        void Delete(int id);        
    }
}
