using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestService.Repositories
{
    public interface IGenericCRUD<M> where M : class
    {
        void Add(M entity);
        void Update(M entity);
        void Delete(int Id);
        M Get(int id);
        List<M> Get();
    }
}
