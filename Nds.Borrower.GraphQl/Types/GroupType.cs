using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class GroupType : ObjectGraphType
    {

        public GroupType(BorrowerData data)
        {
            Name = "Group";

            Field<StringGraphType>("accountnumber");
            Field<StringGraphType>("ssn");
            Field<StringGraphType>("groupid");
            Field<StringGraphType>("lenderid");
            Field<FloatGraphType>("conumber");
            Field<StringGraphType>("gaid");
            Field<StringGraphType>("loantype");
            Field<StringGraphType>("loanstatus");
            Field<StringGraphType>("loanstatusdescription");
            Field<FloatGraphType>("interestrate");
            Field<StringGraphType>("postdefermentgrace");
            Field<DateGraphType>("gradsepdate");
            Field<FloatGraphType>("changeintrate");
            Field<DateGraphType>("changeintdate");
            Field<DateGraphType>("aletterdate");
            Field<FloatGraphType>("amoritzationinterest");
            Field<DateGraphType>("bletterdate");
            Field<StringGraphType>("claimcode");
            Field<DateGraphType>("claimdate");
            Field<StringGraphType>("claimrejectcode");
            Field<DateGraphType>("conversiondate");
            Field<FloatGraphType>("dayspastdue");
            Field<FloatGraphType>("lastdpd");
            Field<DateGraphType>("disclosuredate");
            Field<StringGraphType>("disclosureprintsw");
            Field<DateGraphType>("duedate");
            Field<FloatGraphType>("finalpmtamt");
            Field<StringGraphType>("insuredsts");
            Field<FloatGraphType>("lastpmtamt");
            Field<DateGraphType>("lastpmtdate");
            Field<FloatGraphType>("lengthofgrace");
            Field<FloatGraphType>("monthlypmtamtcurr");
            Field<FloatGraphType>("monthlypmtamtorig");
            Field<FloatGraphType>("numtermperiodsorig");
            Field<FloatGraphType>("numtermperiodremain");
            Field<FloatGraphType>("lpfnumtermpsremain");
            Field<FloatGraphType>("partialpmtamt");
            Field<DateGraphType>("rcadate");
            Field<StringGraphType>("rcastatus");
            Field<FloatGraphType>("refundamt");
            Field<DateGraphType>("refunddate");
            Field<FloatGraphType>("amortizationcandidate");
            Field<FloatGraphType>("gradpmtmths");
            Field<StringGraphType>("claimtype");
            Field<DateGraphType>("defforbstartdate");
            Field<FloatGraphType>("firstpmtdue");
            Field<FloatGraphType>("inactiveloantermper");
            Field<FloatGraphType>("fullpmtswhileunins");
            Field<FloatGraphType>("pmtamtwhileunins");
            Field<StringGraphType>("laststatus");
            Field<FloatGraphType>("pmtswhileunins");
            Field<FloatGraphType>("amtofpmtsduringmth");
            Field<FloatGraphType>("lastbilling");
            Field<FloatGraphType>("lastactivity");
            Field<StringGraphType>("activeinactiveflag");
            Field<StringGraphType>("printendorserstme");
            Field<StringGraphType>("incentivecalcmethod");
            Field<StringGraphType>("comakerssn");
            Field<StringGraphType>("secondcomakerssn");
            Field<StringGraphType>("pmtschedule");
            Field<StringGraphType>("pmtschedule2ndind");
            Field<FloatGraphType>("nbrofpmts");
            Field<FloatGraphType>("gradpmtpctincr");
            Field<FloatGraphType>("latecharges");
            Field<DateGraphType>("gradpmtincreasedate");
            Field<DateGraphType>("incomeevaluationdate");
            Field<FloatGraphType>("pdgenddate");
            Field<FloatGraphType>("lastbackingdteingh");
            Field<DateGraphType>("verificationdate");
            Field<StringGraphType>("finaldemandsentsw");
            Field<FloatGraphType>("achalternateamount");
            Field<StringGraphType>("systemname");
            Field<IntGraphType>("activeloancount");
            Field<FloatGraphType>("delinquentamount");
            Field<DateGraphType>("idrrecertificationdate");
            Field<BooleanGraphType>("idrispermstandard");
            Field<LenderType>("lender");
        }
    }
}
