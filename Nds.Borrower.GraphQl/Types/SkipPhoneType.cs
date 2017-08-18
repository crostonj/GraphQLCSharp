using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class SkipPhoneType : ObjectGraphType
    {
        public SkipPhoneType(BorrowerData data)
        {
            Name = "SkipPhone";

            Field<StringGraphType>("ssn");
            Field<FloatGraphType>("datecreated");
            Field<FloatGraphType>("timecreated");
            Field<FloatGraphType>("seq");
            Field<StringGraphType>("cellphoneconsent");
            Field<StringGraphType>("foreignphone");
            Field<StringGraphType>("intenationalphoneexchange");
            Field<StringGraphType>("areacode");
            Field<FloatGraphType>("phonenumber");
            Field<StringGraphType>("phoneextension");
            Field<StringGraphType>("timezone");
            Field<StringGraphType>("calltimeindicator");
            Field<StringGraphType>("source");
            Field<StringGraphType>("contact");
            Field<FloatGraphType>("lastcalldate");
            Field<StringGraphType>("validphone");
            Field<FloatGraphType>("invaliddate");
            Field<StringGraphType>("invalidbyuserid");
            Field<StringGraphType>("systemname");
        }
    }
}
