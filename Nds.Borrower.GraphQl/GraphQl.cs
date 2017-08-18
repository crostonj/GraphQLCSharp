using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Util;
using Nds.Borrower.GraphQl.Types;
using Nds.Borrower.GraphQl.Models;
using Nds.Borrower.GraphQl.Schema;
using Newtonsoft.Json;
using Nds.Common.GraphQl;

namespace Nds.Borrower.GraphQl
{
    public class GraphQl : IGraphQl
    {

        private readonly ISimpleContainer _container;
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        
        public GraphQl()
        {
            _executer = new DocumentExecuter();
            
            _container = new SimpleContainer();
            _container.Singleton(new BorrowerData());
            _container.Register<BeaconQuery>();
            _container.Register<BeaconMutation>();
            _container.Register<BorrowerType>();
            _container.Register<LoanType>();
            _container.Register<DisbursementType>();
            _container.Singleton(() => new BeaconSchema(type => (GraphType)_container.Get(type)));

            _schema = _container.Get<BeaconSchema>();
        }

        public async Task<ExecutionResult> ExecuteQuery(string query)
        {

            var runResult = Execute(_schema, null, query);
            return await runResult;
        }

        private async Task<ExecutionResult> Execute(
          ISchema schema,
          object rootObject,
          string query,
          string operationName = null,
          Inputs inputs = null)
        {
            return await _executer.ExecuteAsync(schema, rootObject, query, operationName);
        }
    }
}
