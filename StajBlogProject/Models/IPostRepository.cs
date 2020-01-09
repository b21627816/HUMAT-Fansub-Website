using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StajBlogProject.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> getAllPosts();
        Post getPost(int id);
        Post addPost(Post post);
        Post updatePost(Post changedPost);
        Post deletePost(int id);
    }
}
