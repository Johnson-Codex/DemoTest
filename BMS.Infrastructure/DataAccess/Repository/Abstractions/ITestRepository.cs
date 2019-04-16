using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Core.Model;

namespace BMS.Infrastructure.DataAccess.Repository.Abstractions
{
    public interface ITestRepository
    {
        IEnumerable<Test> GetAllTests();
    }
}
