using GraphQL.Types;
using Nds.Borrower.GraphQl.Types;

namespace Nds.Borrower.GraphQl.Schema
{
    public class BeaconMutation : ObjectGraphType
    {
        public BeaconMutation(BorrowerData data)
        {
            Name = "Mutation";

            Field<BorrowerType>(
                "addHistoryNote",
                arguments: new QueryArguments(
                    new[]
                    {
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "ssn", Description = "ssn of the borrower" },
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "notetype", Description = "type of the new note" },
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "notetext", Description = "text of the new note"}
                    }),
                resolve: context =>
                data.AddHistoryNote((string)context.Arguments["ssn"], (string)context.Arguments["notetype"], (string)context.Arguments["notetext"])
            );
        }
    }
}
