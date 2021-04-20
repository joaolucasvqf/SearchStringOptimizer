using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchStringOptimizer.Interfaces
{
    public interface IStringEvaluator
    {
        Task AvaliarString(string SearchString);
    }
}
