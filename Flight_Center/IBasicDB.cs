using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace Flight_Center
    /// <summary>
    /// generic interface for all basic sql functions that fits all tables
    /// </summary>
    interface IBasicDB <T>
   
    {
        T Add(T a, T b);
        T Get(T a);
        T GetAll(T a);
        void Remove(T a);
        void Updte(T a);
    }
}
