using GraphQL.Types;

namespace Nds.Borrower.GraphQl.Types
{
    class AddressType : ObjectGraphType
    {
        public AddressType ()
        {
            Name = "BeaconAddress";

            Field<StringGraphType>("address3");
            Field<StringGraphType>("campaign");
            Field<StringGraphType>("invalidbyuserid");
            Field<DateGraphType>("invaliddate");
            Field<StringGraphType>("invoketrack");
            Field<IntGraphType>("sequencenumber");
            Field<DateGraphType>("serviceattemptdate");
            Field<StringGraphType>("servicecode");
            Field<DateGraphType>("serviceresponsedate");
            Field<StringGraphType>("serviceresponseuser");
            Field<StringGraphType>("source");
            Field<StringGraphType>("type");

            Field<StringGraphType>("id");
            Field<DateGraphType>("adddate");
            Field<StringGraphType>("systemname");
            Field<StringGraphType>("entitystate");
            Field<DateGraphType>("lastupdated");

            Field<BooleanGraphType>("isactive", "Is the address active?");
            Field<BooleanGraphType>("isvalid", "Is the address valid?");
            Field<StringGraphType>("address1");
            Field<StringGraphType>("address2");
            Field<StringGraphType>("addressstatus");
            Field<StringGraphType>("city");
            Field<StringGraphType>("statecode");
            Field<StringGraphType>("county");
            Field<StringGraphType>("zipcode");
            Field<StringGraphType>("countrycode");
            Field<StringGraphType>("foreigncountryindicator");
        }
    }
}
