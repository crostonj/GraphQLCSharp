using GraphQL.Types;
using Nds.Borrower.GraphQl.Models;
using Nds.Borrower.GraphQl.Schema;

namespace Nds.Borrower.GraphQl.Types
{
    public class BorrowerType : ObjectGraphType
    {
        public BorrowerType(BorrowerData data)
        {
            Name = "Borrower";

            Field<NonNullGraphType<StringGraphType>>("ssn", "The ssn of the borrower.");
            Field<StringGraphType>("firstname", "The first name of the borrower.");
            Field<StringGraphType>("lastname", "The last name of the borrower.");
            Field<StringGraphType>("middleinitial", "The middle initial of the borrower.");
            Field<DateGraphType>("birthdate", "The birth date  of the borrower.");
            Field<BooleanGraphType>("addressesinsync", "Are addresses in sync?");
            Field<StringGraphType>("addressstatus", "The address status of the borrower.");
            Field<StringGraphType>("phonestatus", "The phone status of the borrower.");



            Field<StringGraphType>("cpcflag");
            Field<StringGraphType>("addresstouse");
            Field<StringGraphType>("permtimezone");
            Field<StringGraphType>("permaddresssource");
            Field<StringGraphType>("permforeigncountry");
            Field<StringGraphType>("permaddress1");
            Field<StringGraphType>("permaddress2");
            Field<StringGraphType>("permcity");
            Field<StringGraphType>("permzipcode");
            Field<StringGraphType>("permcountrycode");
            Field<StringGraphType>("permstatecode");
            Field<StringGraphType>("permcountry");
            Field<StringGraphType>("permintlphoneexchnage");
            Field<StringGraphType>("permareacode");
            Field<StringGraphType>("permphonenumber");
            Field<StringGraphType>("permphoneextension");
            Field<StringGraphType>("permcalltimeind");
            Field<StringGraphType>("permforeignphoneind");
            Field<StringGraphType>("permphonestatus");
            Field<StringGraphType>("temptimezone");
            Field<StringGraphType>("tempaddresssource");
            Field<StringGraphType>("tempforeigncountry");
            Field<StringGraphType>("tempaddress1");
            Field<StringGraphType>("tempaddress2");
            Field<StringGraphType>("tempcity");
            Field<StringGraphType>("tempzipcode");
            Field<StringGraphType>("tempcountrycode");
            Field<StringGraphType>("tempstatecode");
            Field<StringGraphType>("tempcountry");
            Field<StringGraphType>("tempintlphoneexchange");
            Field<StringGraphType>("tempareacode");
            Field<StringGraphType>("tempphonenumber");
            Field<StringGraphType>("tempphoneext");
            Field<StringGraphType>("tempcalltimeind");
            Field<StringGraphType>("tempphonestatus");
            Field<StringGraphType>("tempforeignphoneind");
            Field<StringGraphType>("otherphoneind");
            Field<StringGraphType>("otherphonenumber");
            Field<StringGraphType>("othercalltimeind");
            Field<StringGraphType>("otherphoneareacode");
            Field<StringGraphType>("otherinphoneexchange");
            Field<StringGraphType>("otherforeignphoneind");
            Field<StringGraphType>("otherphonestatus");
            Field<StringGraphType>("legalresidencecountry");
            Field<StringGraphType>("legalresidencestate");
            Field<StringGraphType>("callneededsw");
            Field<StringGraphType>("callneededuns");
            Field<StringGraphType>("slschoolcode");
            Field<StringGraphType>("slbranch");
            Field<StringGraphType>("enrolldate");
            Field<StringGraphType>("enrolledstatus");
            Field<StringGraphType>("halfofmonthpd");
            Field<StringGraphType>("insuredsw");


            Field<FloatGraphType>("maxnumdaypd");
            Field<FloatGraphType>("nbrattemptspercycle");
            Field<FloatGraphType>("dayssincebadaddress");
            Field<FloatGraphType>("gradsepdate");
            Field<FloatGraphType>("oldestintratepif");
            Field<StringGraphType>("previousssn");
            Field<StringGraphType>("recordlocked");
            Field<StringGraphType>("recordlockeduns");
            Field<StringGraphType>("callstatusoverride");
            Field<FloatGraphType>("dayspastdueunin");
            Field<StringGraphType>("corrprintcontrol");
            Field<FloatGraphType>("datelastchanged");
            Field<FloatGraphType>("totalnbrofloans");
            Field<StringGraphType>("contactinstructions");
            Field<StringGraphType>("loanposition");
            Field<StringGraphType>("sex");
            Field<StringGraphType>("race");
            Field<FloatGraphType>("dtee8pos");
            Field<StringGraphType>("driverslicense");
            Field<FloatGraphType>("returnedcheckcount");
            Field<StringGraphType>("citizenship");
            Field<StringGraphType>("alienidnumber");
            Field<FloatGraphType>("archivedate");
            Field<FloatGraphType>("schoolcertdate");
            Field<FloatGraphType>("lastskipactivitydate");
            Field<FloatGraphType>("suppressondate");
            Field<FloatGraphType>("creditscore");
            Field<StringGraphType>("legalsubstatus");
            Field<StringGraphType>("enrollmentsource");
            Field<StringGraphType>("schooldeferrequested");
            Field<StringGraphType>("incenteligibility");
            Field<StringGraphType>("specialinstructcode");
            Field<StringGraphType>("collectiongroup");
            Field<StringGraphType>("collectorcode");
            Field<StringGraphType>("changedbyuser");
            Field<FloatGraphType>("daterecordadded");

            Field<ListGraphType<EmployerType>>("employers", "The employers  of the borrower.");
            Field<ListGraphType<BorrowerHistoryType>>("borrowerhistories", "The history of the borrower.");
            Field<ListGraphType<LoanType>>("loans", "The loans for the borrower.");

            Field<ListGraphType<GroupType>>("groups", "The groups for the borrower.");
            Field<ListGraphType<DigitalType>>("digitals", "The digitals for the borrower.");
            Field<ListGraphType<SkipAddressType>>("skipaddresses", "The skip addresses for the borrower.");
            Field<ListGraphType<SkipEmailType>>("skipemails", "The skip emails for the borrower.");
            Field<ListGraphType<SkipPhoneType>>("skipphones", "The skip phones for the borrower.");
            Field<AccountType>("account", "The account of this borrower");
            Field<ListGraphType<VerificationType>>("verifications", "The verifications for the borrower.");
            Field<ListGraphType<PaymentType>>("payments", "The payments for the borrower.");

            Field<StringGraphType>("systemname", "The system name of the borrower account.");
            Field<ListGraphType<AddressType>>("addresses", resolve: context => data.GetBorrowerAddressesBySsn(context.Source as Models.Borrower));
            Field<ListGraphType<BeaconActivityType>>("activities",resolve: context => data.GetBorrowerActivitiesBySsn(context.Source as Models.Borrower));
        }
    }
}
