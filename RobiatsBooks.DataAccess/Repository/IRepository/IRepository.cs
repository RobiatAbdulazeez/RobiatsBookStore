using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace RobiatsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); //Retrives a category from the database by the category id  and list the categopry based on requirements

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null //used for foreign keys references
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity); //to add an entity

        void Remove(int id); //to remove a category from the table

        void Remove(T entity); //this is another way to remove an object

        void RemoveRange(IEnumerable<T> entity);  //remove a complete range of entities 


    }
}
