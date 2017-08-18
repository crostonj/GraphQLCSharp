namespace GraphQL.Tests.Borrower
{
    public class BorrowerBasicQueryTests : BorrowerTestBase
    {

        public BorrowerBasicQueryTests()
        {
            
        }
       
        [Test]
        public void can_query_for_borrowers()
        {
            var query = @"
               {
                  borrower(ssn: ""999999485"") {
                    firstname
                    lastname
                  }
               }
            ";

            var expected = @"{                                
                                borrower: {
                                  firstname: 'SYLVIA        ',
                                  lastname: 'CHRISTIANSON             '             
                                          }                                   
                             }";

            AssertQuerySuccess(query, expected);
        }

        [Test]
        public void can_return_firstname()
        {
            var query = @"
               {
                  borrower(ssn: ""999999485"") {
                    firstname                    
                  }
               }
            ";

            var expected = @"{
              borrower: {
                firstname: 'SYLVIA        '                
              }
            }";

            AssertQuerySuccess(query, expected);
        }
    }
}
