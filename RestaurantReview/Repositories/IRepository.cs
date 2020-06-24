using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Repositories
{
    public interface IRepository<T> where T : class
    {
        
            public IEnumerable<T> GetAll();
            T GetById(int id);

        void Create(T obj);
        void Update(T obj);

    }
}
