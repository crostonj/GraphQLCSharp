using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class PaymentType : ObjectGraphType
    {
        public PaymentType(BorrowerData data)
        {
            Name = "Payment";

            Field<StringGraphType>("ssn");
            Field<FloatGraphType>("effectivedate");
            Field<FloatGraphType>("posteddate");
            Field<StringGraphType>("lockboxseqnumber");
            Field<StringGraphType>("lockboxsubseqnumber");
            Field<StringGraphType>("groupid");
            Field<StringGraphType>("loannumber");
            Field<FloatGraphType>("paymentamount");
            Field<FloatGraphType>("allocationamount");
            Field<FloatGraphType>("appliedinterest");
            Field<FloatGraphType>("appliedfees");
            Field<FloatGraphType>("appliedprincipal");
            Field<FloatGraphType>("appliedrefund");
            Field<StringGraphType>("transactioncode");
            Field<StringGraphType>("cancelreasoncode");
            Field<StringGraphType>("transactioncodedesc");
            Field<FloatGraphType>("unappliedpostdate");
            Field<FloatGraphType>("unappliedamount");
            Field<StringGraphType>("userid");
            Field<StringGraphType>("systemname");
        }
    }
}
