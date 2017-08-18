using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;

namespace Nds.Common.GraphQl
{
    public interface IGraphQl
    {
        Task<ExecutionResult> ExecuteQuery(string query);

    }
}
