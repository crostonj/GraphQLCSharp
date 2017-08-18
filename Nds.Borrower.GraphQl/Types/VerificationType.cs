using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class VerificationType : ObjectGraphType
    {
        public VerificationType(BorrowerData data)
        {
            Name = "Verification";

            Field<StringGraphType>("ssn");
            Field<StringGraphType>("category");
            Field<FloatGraphType>("systemdate");
            Field<FloatGraphType>("systemtime");
            Field<FloatGraphType>("sequence");
            Field<FloatGraphType>("verifieddate");
            Field<FloatGraphType>("verifiedtime");
            Field<StringGraphType>("username");
            Field<StringGraphType>("source");
            Field<StringGraphType>("scope");
            Field<FloatGraphType>("canceleddate");
            Field<FloatGraphType>("canceledtime");
            Field<StringGraphType>("canceledby");
            Field<StringGraphType>("systemname");
        }
    }
}
