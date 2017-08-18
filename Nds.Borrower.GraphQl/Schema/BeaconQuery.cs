using GraphQL.Types;
using Nds.Borrower.GraphQl.Types;

namespace Nds.Borrower.GraphQl.Schema
{
    public class BeaconQuery : ObjectGraphType
    {
        public BeaconQuery(BorrowerData data)
        {
            Name = "Query";
            
            Field<BorrowerType>(
                "borrower",
                arguments: new QueryArguments(
                    new[]
                    {
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "ssn", Description = "ssn of the borrower" }
                    }),
                resolve: context => 
                data.GetBorrowerBySsnAsync((string)context.Arguments["ssn"])
            );
        }
    }
}
