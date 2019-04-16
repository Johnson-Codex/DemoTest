using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BusinessLogic.Repository.Abstractions;
using BMS.Core.Model;
using BMS.Infrastructure.DataAccess.Repository.Abstractions;
using BMS.Infrastructure.DataAccess.Repository;

namespace BMS.BusinessLogic.Repository
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public IEnumerable<Test> GetAllFailedTest()
        {
            return _testRepository.GetAllTests().Where(x => x.IsDeleted == false);
        }

        public IEnumerable<Test> GetAllPassedTest()
        {
            return _testRepository.GetAllTests().Where(x => x.IsDeleted == true);
        }

        public IEnumerable<Test> GetAllTestByUserId(int id)
        {
            return _testRepository.GetAllTests().Where(x => x.Id == id);
        }
    }
}
