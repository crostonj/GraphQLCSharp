using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    class BorrowerHistoryType : ObjectGraphType
    {

        public BorrowerHistoryType(BorrowerData data)
        {
            Name = "BorrowerHistory";

            Field<StringGraphType>("ssn");
            Field<FloatGraphType>("historydate");
            Field<FloatGraphType>("historytime");
            Field<FloatGraphType>("sequencenumber");
            Field<StringGraphType>("historytype");
            Field<StringGraphType>("historycode");
            Field<StringGraphType>("historytext");
            Field<StringGraphType>("userid");
            Field<StringGraphType>("systemname");

        }
    }
}
