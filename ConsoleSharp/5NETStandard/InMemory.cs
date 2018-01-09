using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharp._5NETStandard
{
    class InMemory
    {
    }
}

//https://docs.microsoft.com/en-us/ef/core/what-is-new/

//Package manager console:
//PM> Install-Package Microsoft.EntityFrameworkCore.InMemory -Version 2.0.1

//NET Core CLI:
//$ dotnet add package Microsoft.EntityFrameworkCore.InMemory

//Once the InMemory provider is set up, we’ll need to add a constructor to our DbContext that accepts a DbContextOptions object. The DbContextOptions object will allow us to specify the InMemory provider via configuration thus allowing us to swap the provider as needed.

//public class BloggingContext : DbContext
//{
//    public BloggingContext()
//    { }

//    public BloggingContext(DbContextOptions<BloggingContext> options)
//        : base(options)
//    { }
//}
//With the our DbContext implementation in place we’re able to then create a new instance of the context.Calling the UseInMemoryDatabase extension method configures the context to connect to an in-memory database. Once the database connection is established, we can seed it with data and run our tests.

//[TestMethod]
//public void Find_searches_url()
//{
//    var options = new DbContextOptionsBuilder<BloggingContext>()
//        .UseInMemoryDatabase(databaseName: "Find_searches_url")
//        .Options;

//    // Insert seed data into the database using one instance of the context
//    using (var context = new BloggingContext(options))
//    {
//        context.Blogs.Add(new Blog { Url = "http://sample.com/cats" });
//        context.Blogs.Add(new Blog { Url = "http://sample.com/catfish" });
//        context.Blogs.Add(new Blog { Url = "http://sample.com/dogs" });
//        context.SaveChanges();
//    }

//    // Use a clean instance of the context to run the test
//    using (var context = new BloggingContext(options))
//    {
//        var service = new BlogService(context);
//        var result = service.Find("cat");
//        Assert.AreEqual(2, result.Count());
//    }
//}