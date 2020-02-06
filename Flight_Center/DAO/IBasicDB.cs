using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace Flight_Center
{ 
    /// <summary>
    /// generic interface for all basic sql functions that fits all tables
    /// </summary>
   
    public interface IBasicDB <T> where T :IPoco
   
    {
        void Add(T t);
        T Get(int id);
        IList<T> GetAll();
        void Remove(T t);
        void Update(T t);
    }
}
