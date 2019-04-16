using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BMS.ApplicationServices.Model.View;
using BMS.ApplicationServices.Repository.Abstractions;
using BMS.BusinessLogic.Repository.Abstractions;
using BMS.Core.Model;

namespace BMS.ApplicationServices.Repository
{
    public class TestAppService : ITestAppService
    {
        private readonly ITestService _testService;

        public TestAppService(ITestService testService)
        {
            _testService = testService;
        }
        public IEnumerable<TestViewModel> GetAllTestEitherFailedOrPass(int id)
        {
            switch (id)
            {
                case 0:
                   return _testService.GetAllFailedTest()
                        .Select(Mapper.Map<Test,TestViewModel>);

                    var testDatas = Mapper.Map<Test, TestViewModel>(new Test());

                    break;

                case 1:
                    return _testService.GetAllFailedTest()
                       .Select(Mapper.Map<Test, TestViewModel>);
                    break;
                default:
                    return _testService.GetAllFailedTest()
                       .Select(x => Mapper.Map<Test, TestViewModel>(x));
                    break;
            }

        }
    }
}
