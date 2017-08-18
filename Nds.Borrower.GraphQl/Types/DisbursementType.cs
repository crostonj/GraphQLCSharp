using GraphQL.Types;
using Nds.Borrower.GraphQl.Models;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class DisbursementType : ObjectGraphType
    {

        public DisbursementType(BorrowerData data)
        {
            Name = "Disbursement";

            Field<StringGraphType>("ssn");
            Field<FloatGraphType>("loannumber");
            Field<FloatGraphType>("disbnumber");
            Field<FloatGraphType>("disbseq");
            Field<StringGraphType>("lenderid");
            Field<StringGraphType>("feerespldlenderid");
            Field<StringGraphType>("madebyldlenderid");
            Field<StringGraphType>("riskfeerespldlenderi");
            Field<StringGraphType>("reasoncode");
            Field<StringGraphType>("cancellenderid");
            Field<StringGraphType>("disbstatus");
            Field<FloatGraphType>("dbdate");
            Field<FloatGraphType>("prinamount");
            Field<FloatGraphType>("postdate");
            Field<FloatGraphType>("canceldate");
            Field<StringGraphType>("byuser");
            Field<StringGraphType>("cancelledbyuser");
            Field<FloatGraphType>("guaranteedgrossamt");
            Field<StringGraphType>("eftindicator");
            Field<StringGraphType>("bankid");
            Field<StringGraphType>("bankaccount");
            Field<StringGraphType>("checknumber");
            Field<FloatGraphType>("insurfee");
            Field<FloatGraphType>("origfee");
            Field<FloatGraphType>("insurancerate");
            Field<FloatGraphType>("originationrate");
            Field<FloatGraphType>("lenderriskrate");
            Field<FloatGraphType>("lenderriskfee");
            Field<StringGraphType>("accountingstage");
            Field<StringGraphType>("postingstatus");
            Field<StringGraphType>("promissorynote");
            Field<FloatGraphType>("promissorynotedate");
            Field<FloatGraphType>("promissoryreturneddt");
            Field<FloatGraphType>("purchasedate");
            Field<FloatGraphType>("prinpurchased");
            Field<FloatGraphType>("intpurchased");
            Field<FloatGraphType>("capdintpurchased");
            Field<FloatGraphType>("checkeftdate");
            Field<FloatGraphType>("checkcasheddate");
            Field<FloatGraphType>("adjustdate");
            Field<FloatGraphType>("bnbr");
            Field<StringGraphType>("sts2z");
            Field<StringGraphType>("origfeeresp");
            Field<StringGraphType>("insfeeresp");
            Field<StringGraphType>("riskfeeresp");
            Field<FloatGraphType>("posteddate");
            Field<FloatGraphType>("lockboxseqnbr");
            Field<FloatGraphType>("lockboxsubseqnbr");
            Field<StringGraphType>("cancelsource");
            Field<StringGraphType>("postsource");
        }
    }
}
