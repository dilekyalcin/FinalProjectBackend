using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() newlenebilir demek. Yani IEntity newlenemediği için bu özellikle IEntity de kullanımdan eleriz. Sadece IEntity implement eden nesneler kullanılabilir
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null); // null ifadesi filtre vermeyedebilirsin yani tüm datayı getirebilirsin
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       // List<T> GetAllByCategory(int categoryId); yukarda yazılan yapıdan dolayı böyle bir şeye ihtiyacımız kalmaz
    }
}
