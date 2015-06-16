using Neo4jRepository.Data.Model;
using Neo4jRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jRepository.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncMain().Wait();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static async Task AsyncMain()
        {
            BlogPostRepository _repo = new BlogPostRepository();
            BlogPost post1 = new BlogPost()
            {
                Author = "John Smith",
                Title = "Hello Blog!",
                Content = "Test blog content"
            };
            BlogPost post2 = new BlogPost()
            {
                Author = "Jane Smith",
                Title = "Hello Blog!",
                Content = "Test blog content"
            };

            _repo.AddOrUpdate(post1);
            _repo.AddOrUpdate(post2);
            IEnumerable<BlogPost> blogPosts = await _repo.All();
            IEnumerable<BlogPost> janesPosts = await _repo.Where(b => b.Author == "Jane Smith");
            foreach(var blogPost in blogPosts)
            {
                Console.WriteLine(blogPost.Author);
            }

            foreach(var blogPost in janesPosts)
            {
                Console.WriteLine(blogPost.Author);
            }
        }
    }
}
