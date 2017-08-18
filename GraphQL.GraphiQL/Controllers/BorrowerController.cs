using System.Web.Http;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.GraphiQL.Controllers;
using Nds.Borrower.GraphQl;

namespace GraphQL.GraphiQL.Controllers
{

    //[Route("api/borrower")]
    public class BorrowerController : ApiController
    {
        private readonly Nds.Borrower.GraphQl.GraphQl _graphQl;

        public BorrowerController()
        {
            _graphQl = new GraphQl();
        }

        // GET: borrower
        public IHttpActionResult Get()
        {
            //Return json introspection of the borrower schema
            string query = @"{__type(name: 'Borrower') {name fields {name description type {name kind}}}}";

            //_graphQl = new Nds.Borrower.GraphQl.GraphQl();

            var result = _graphQl.ExecuteQuery(query);
            return Ok(result.Result);
        }
       

        // POST: called from GraphiQL
        public async Task<ExecutionResult> Post(GraphQLQuery query)
        {
            //Return the GraphQL result from the borrower query
            //_graphQl = new Nds.Borrower.GraphQl.GraphQl();
            return await _graphQl.ExecuteQuery(query.Query);
        }
    }

    public class GraphQLQuery
    {
        public string Query { get; set; }
        public string Variables { get; set; }
    }
}
