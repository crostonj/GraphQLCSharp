using System;
using GraphQL.Types;

namespace Nds.Borrower.GraphQl.Models
{
    public class BeaconActivity : ObjectGraphType
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ActivityName
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// ActivityDescription
        /// </summary>
        public string ActivityDescription { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Activity Date
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// Completion Date
        /// </summary>
        public DateTime CompleteDate { get; set; }
    }

    class BeaconActivityType : ObjectGraphType
    {
        public BeaconActivityType()
        {
            Name = "BeaconActivity";
            Field<IntGraphType>("id", "Id of the borrower activity?");
            Field<StringGraphType>("activityname", "Name of the borrower activity.");
            Field<StringGraphType>("activitydescription", "Description of the borrower activity.");
            Field<StringGraphType>("status", "Status of the borrower activity");
            Field<DateGraphType>("requestdate", "Requested date of the borrower activity.");
            Field<DateGraphType>("completedate", "Completed date of the borrower activity.");
        }
    }
}
