using LibraryManagementCourse.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllAuthorWithBook();

        Author GetWithBooks(int id);   
    }
}
