using System.Collections.Specialized;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Models;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    class EmployerType : ObjectGraphType
    {

        public EmployerType(BorrowerData data)
        {
            Name = "Employer";

            Field<StringGraphType>("ssn");
            Field<StringGraphType>("boredrrefind");
            Field<FloatGraphType>("edrrefnumber");
            Field<FloatGraphType>("seqnumber");
            Field<StringGraphType>("companyname");
            Field<StringGraphType>("occupation");
            Field<StringGraphType>("addressstatus");
            Field<StringGraphType>("address1");
            Field<StringGraphType>("address2");
            Field<StringGraphType>("city");
            Field<StringGraphType>("countrycode");
            Field<StringGraphType>("statecode");
            Field<StringGraphType>("zipcode");
            Field<StringGraphType>("phonestatus");
            Field<StringGraphType>("areacode");
            Field<FloatGraphType>("phonenumber");
            Field<StringGraphType>("phonenumberext");
            Field<StringGraphType>("intnatlphexchg");
            Field<StringGraphType>("calltimeind");
            Field<StringGraphType>("timezone");
            Field<StringGraphType>("emailaddress");
            Field<StringGraphType>("emailstatus");
            Field<StringGraphType>("supervisorname");
            Field<StringGraphType>("supervisorcontactsw");
            Field<StringGraphType>("supvphonestatus");
            Field<StringGraphType>("supvareacode");
            Field<FloatGraphType>("supervisorphone");
            Field<StringGraphType>("supervisorphoneext");
            Field<StringGraphType>("supvintnatlphexchg");
            Field<StringGraphType>("supvemailaddress");
            Field<StringGraphType>("supvemailstatus");
            Field<FloatGraphType>("employmentenddate");
            Field<StringGraphType>("systemname");
        }
    }
}
