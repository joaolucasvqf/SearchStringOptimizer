using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchStringOptimizer.Interfaces
{
    public interface ISearchOptimizer
    {
        Task<string> OtimizarString(string initialString);
    }
}
