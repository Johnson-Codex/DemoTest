using System.Collections.Generic;
using System.Linq;
using BMS.Core.Model;
using BMS.Infrastructure.DataAccess.DbContext;
using BMS.Infrastructure.DataAccess.Repository.Abstractions;

namespace BMS.Infrastructure.DataAccess.Repository
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Test> GetAllTests()
        {
            return Get();
        }
    }
}
