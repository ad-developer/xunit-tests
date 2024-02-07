using Applications.CustormerApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NSubstitute;


namespace UnitTests.Fixtures
{

    /// <summary>
    /// ApplicationDbContextFixture
    /// https://gist.github.com/jhoerr/9a064c83d04076fb056b98a30f4664f9
    /// </summary>
    public class ApplicationDbContextFixture
    {
        public static IApplicationDBContext Create() => Create(new List<Customer>());

        public static IApplicationDBContext Create(List<Customer> entities)
        {
            var queryable = entities.AsQueryable();
            var mockSet = Substitute.For<DbSet<Customer>, IQueryable<Customer>>();

            // Query the set
            ((IQueryable<Customer>)mockSet).Provider.Returns(queryable.Provider);
            ((IQueryable<Customer>)mockSet).Expression.Returns(queryable.Expression);
            ((IQueryable<Customer>)mockSet).ElementType.Returns(queryable.ElementType);
            ((IQueryable<Customer>)mockSet).GetEnumerator().Returns((IEnumerator<Customer>)queryable.GetEnumerator());

            // Modify the set
            mockSet.When(set => set.Add(Arg.Any<Customer>())).Do(info =>
            {
                if(info.Arg<Customer>().Id == 0)
                {
                    var rnd = new Random();
                    var num = rnd.Next();

                    info.Arg<Customer>().Id = num;
                }

                entities.Add(info.Arg<Customer>());
            });

            mockSet.When(set => set.Remove(Arg.Any<Customer>())).Do(info => entities.Remove(info.Arg<Customer>()));
            
            var dbContext = Substitute.For<IApplicationDBContext>();
            dbContext.Customers.Returns(mockSet);
            
            return dbContext;
        }
    }
}

