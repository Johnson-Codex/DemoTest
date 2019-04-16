using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.ApplicationServices.Model.View;

namespace BMS.ApplicationServices.Repository.Abstractions
{
    public interface ITestAppService
    {
        IEnumerable<TestViewModel> GetAllTestEitherFailedOrPass(int id);
    }
}
