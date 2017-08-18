using System;
using GraphQL.Types;

namespace Nds.Borrower.GraphQl.Schema
{
    public class BeaconSchema : GraphQL.Types.Schema
    {
        public BeaconSchema()
        {
            
        }
        public BeaconSchema(Func<Type, GraphType> resolveType)
            : base(resolveType)
        {
            Query = (ObjectGraphType)resolveType(typeof(BeaconQuery));
            Mutation = (ObjectGraphType)resolveType(typeof(BeaconMutation));
        }
    }
}
