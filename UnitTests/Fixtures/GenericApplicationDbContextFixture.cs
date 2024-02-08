using Applications.CustormerApp;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace UnitTests.Fixtures
{
    public class GenericApplicationDbContextFixture<T>
    where T : class, IEntity
    {
        public static IApplicationDBContext Create() => Create(new List<T>());

        public static IApplicationDBContext Create(List<T> entities)
        {
            var queryable = entities.AsQueryable();
            var mockSet = Substitute.For<DbSet<T>, IQueryable<T>>();

            // Query the set
            ((IQueryable<T>)mockSet).Provider.Returns(queryable.Provider);
            ((IQueryable<T>)mockSet).Expression.Returns(queryable.Expression);
            ((IQueryable<T>)mockSet).ElementType.Returns(queryable.ElementType);
            ((IQueryable<T>)mockSet).GetEnumerator().Returns((IEnumerator<T>)queryable.GetEnumerator());

            // Modify the set
            mockSet.When(set => set.Add(Arg.Any<T>())).Do(info => {
                var rnd = new Random();
                var num = rnd.Next();

                var ent = info.Arg<T>();
                ent.Id = num;

                entities.Add(ent);
            });
            mockSet.When(set => set.Remove(Arg.Any<T>())).Do(info => entities.Remove(info.Arg<T>()));

            var dbContext = Substitute.For<IApplicationDBContext>();
            dbContext.Set<T>().Returns(mockSet);
          
            return dbContext;
        }
    }
}

