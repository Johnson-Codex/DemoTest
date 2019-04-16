using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Core.Model;

namespace BMS.BusinessLogic.Repository.Abstractions
{
    public interface ITestService
    {
        IEnumerable<Test> GetAllFailedTest();
        IEnumerable<Test> GetAllPassedTest();
        IEnumerable<Test> GetAllTestByUserId(int id);
    }
}
