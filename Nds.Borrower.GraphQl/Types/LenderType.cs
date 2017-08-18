using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class LenderType : ObjectGraphType
    {
        public LenderType(BorrowerData data)
        {
            Name = "Lender";

            Field<StringGraphType>("lenderid");
            Field<StringGraphType>("lendernumber");
            Field<StringGraphType>("lendername");
    }
    }
}
