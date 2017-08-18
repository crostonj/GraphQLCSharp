using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class SkipEmailType : ObjectGraphType
    {

        public SkipEmailType(BorrowerData data)
        {
            Name = "SkipEmail";

            Field<StringGraphType>("ssn");
            Field<FloatGraphType>("datecreated");
            Field<FloatGraphType>("timecreated");
            Field<FloatGraphType>("seq");
            Field<StringGraphType>("emailaddress");
            Field<StringGraphType>("contact");
            Field<FloatGraphType>("lastcontactdate");
            Field<StringGraphType>("validemail");
            Field<FloatGraphType>("invaliddate");
            Field<StringGraphType>("invalidbyuserid");
            Field<FloatGraphType>("nf_sv_attempt_dt");
            Field<StringGraphType>("nf_sv_code");
            Field<FloatGraphType>("nf_sv_resp_dt");
            Field<StringGraphType>("nf_sv_resp_user_id");
            Field<StringGraphType>("systemname");
        }
    }
}
