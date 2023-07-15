using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null); // null ifadesi filtre vermeyedebilirsin yani tüm datayı getirebilirsin
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       // List<T> GetAllByCategory(int categoryId); yukarda yazılan yapıdan dolayı böyle bir şeye ihtiyacımız kalmaz
    }
}
