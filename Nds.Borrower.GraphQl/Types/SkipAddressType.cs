using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class SkipAddressType : ObjectGraphType
    {

        public SkipAddressType(BorrowerData data)
        {
            Name = "SkipAddress";

            Field<StringGraphType>("ssn");
            Field<DateGraphType>("datecreated");
            Field<DateGraphType>("timecreated");
            Field<FloatGraphType>("seq");
            Field<StringGraphType>("validaddress");
            Field<StringGraphType>("addressline1");
            Field<StringGraphType>("addressline2");
            Field<StringGraphType>("addressline3");
            Field<StringGraphType>("county");
            Field<StringGraphType>("city");
            Field<StringGraphType>("state");
            Field<StringGraphType>("zip");
            Field<StringGraphType>("country");
            Field<StringGraphType>("foreigncountryindicator");
            Field<StringGraphType>("addressource");
            Field<FloatGraphType>("invaliddate");
            Field<StringGraphType>("invalidbyuserid");
            Field<DateGraphType>("io_sv_attempt_dt");
            Field<StringGraphType>("io_sv_code");
            Field<DateGraphType>("io_sv_resp_dt");
            Field<StringGraphType>("io_sv_resp_user_id");
            Field<StringGraphType>("io_cd1a_do_not_use");
            Field<StringGraphType>("io_invoke_track");
            Field<StringGraphType>("inactive");
            Field<StringGraphType>("io_rcd_crt_campaign");
            Field<StringGraphType>("systemname");

        }
    }
}
