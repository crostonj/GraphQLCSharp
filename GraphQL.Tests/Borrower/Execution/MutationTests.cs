using System;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Should;

namespace GraphQL.Tests.Borrower.Execution
{
   
    public class MutationTests : BorrowerTestBase
    {
        [Test]
        public void addHistoryNote_mutation()
        {
            var query = @"
                mutation updateBorrower {
                    addHistoryNote(ssn: ""999999485"", notetype: ""150"", notetext: ""new note"")
                    {
                        ssn
                        firstname
                    }
                }
            ";

            var expected = @"
                {
  
                    addHistoryNote: {
                        ""ssn"": ""999999485"",
                        ""firstname"": ""SYLVIA        ""
                    },                    
                }
                ";

            AssertQuerySuccess(query, expected);
        }

        [Test]
        public void evaluates_mutations_correctly_in_the_presense_of_a_failed_mutation()
        {
            var query = @"
                mutation M {
                  first: immediatelyChangeTheNumber(newNumber: 1) {
                    theNumber
                  }
                  second: promiseToChangeTheNumber(newNumber: 2) {
                    theNumber
                  }
                  third: failToChangeTheNumber(newNumber: 3) {
                    theNumber
                  }
                  fourth: promiseToChangeTheNumber(newNumber: 4) {
                    theNumber
                  }
                  fifth: immediatelyChangeTheNumber(newNumber: 5) {
                    theNumber
                  }
                  sixth: promiseAndFailToChangeTheNumber(newNumber: 6) {
                    theNumber
                  }
                }
            ";

            var expected = @"
                {
                  'first': {
                    'theNumber': 1
                  },
                  'second': {
                    'theNumber': 2
                  },
                  'third': null,
                  'fourth': {
                    'theNumber': 4
                  },
                  'fifth': {
                    'theNumber': 5
                  },
                  'sixth': null
                }";

            //var result = AssertQueryWithErrors(query, expected, root: new Root(6), expectedErrorCount: 2);
            //result.Errors.First().InnerException.Message.ShouldEqual("Cannot change the number");
            //result.Errors.Last().InnerException.Message.ShouldEqual("Cannot change the number");
        }
    }
}
