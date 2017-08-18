using GraphQL.Types;
using Nds.Borrower.GraphQl.Types;
using Nds.Borrower.GraphQl.Schema;


namespace GraphQL.Tests.Borrower
{
    public class BorrowerTestBase : QueryTestBase<BeaconSchema>
    {
        public BorrowerTestBase()
        {
            Services.Singleton(new BorrowerData());
            Services.Register<BeaconQuery>();
            Services.Register<BorrowerType>();
            Services.Register<LoanType>();
            Services.Register<DisbursementType>();

            Services.Singleton(() => new BeaconSchema(type => (GraphType)Services.Get(type)));
        }
    }
}
