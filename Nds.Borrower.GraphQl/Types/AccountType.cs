using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class AccountType : ObjectGraphType
    {
        public AccountType(BorrowerData data)
        {
            Name = "Account";

            Field<StringGraphType>("accountid");
            Field<FloatGraphType>("payoffbalance");
            Field<FloatGraphType>("principalbalance");
            Field<FloatGraphType>("interestbalance");
            Field<FloatGraphType>("feesbalance");
            Field<FloatGraphType>("dailyinterestamount");
            Field<FloatGraphType>("delinquentamount");
            Field<IntGraphType>("maximumdayspastdue"); 
            Field<FloatGraphType>("tendaypayoffamount");
            Field<FloatGraphType>("lastpaymentamount"); 
            Field<DateGraphType>("lastpaymentdate");
            Field<FloatGraphType>("regularpayment");
            Field<FloatGraphType>("loancount");
            Field<BooleanGraphType>("iserror");
            Field<StringGraphType>("systemname");
        }
    }
}
