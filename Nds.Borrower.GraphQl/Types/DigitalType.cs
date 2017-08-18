using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class DigitalType : ObjectGraphType
    {

        public DigitalType(BorrowerData data)
        {
            Name = "Digital";

            Field<StringGraphType>("ssn");
            Field<StringGraphType>("emailreferenceindicator");
            Field<FloatGraphType>("oc_edr_ref_number");
            Field<FloatGraphType>("oc_seq_number");
            Field<FloatGraphType>("ln_num");
            Field<FloatGraphType>("db_disb_number");
            Field<StringGraphType>("emailaddress");
            Field<StringGraphType>("emailindicator");
            Field<StringGraphType>("emailstatus");
            Field<DateGraphType>("lastchangedate");
            Field<StringGraphType>("systemname");
        }
    }
}
