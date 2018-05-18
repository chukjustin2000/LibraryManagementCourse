
using LibraryManagementCourse.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data
{
    public static class DbInitialize
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();

                //Add Customers
                var chuks = new Customer { Name = "Chukwuka Egbujio" };
                var uche = new Customer { Name = "Uchendu Egbujio" };
                var musa = new Customer { Name = "Joshua Musa" };

                context.Customers.Add(chuks);
                context.Customers.Add(uche);
                context.Customers.Add(musa);

                var freeman = new Author
                {
                    Name = "Adam Freeman",
                    Books = new List<Book>
                    {
                        new Book {Title = "Essential Angular For ASP.NET Core"},
                        new Book {Title = "Pro ASP.NET Core MVC 2"}
                    }
                };
                var robin = new Author
                {
                    Name ="Robin Dewson",
                    Books= new List<Book>
                    {
                        new Book {Title = "Begining SQL Server For Devlopers"},
                        new Book {Title = "Modern API Design With Asp.Net Core 2"}
                    }
                };

                context.Authors.Add(freeman);
                context.Authors.Add(robin);

                context.SaveChanges();
            }


        }
    }
}
