using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StajBlogProject.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> getAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Post getPost(int id)
        {
            return _context.Posts.Find(id);
        }

        public Post addPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public Post updatePost(Post changedPost)
        {
            var post = _context.Posts.Attach(changedPost);
            post.State = EntityState.Modified;
            _context.SaveChanges();
            return changedPost;
        }

        public Post deletePost(int id)
        {
            Post post = _context.Posts.Find(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }

            return post;
        }
    }
}
