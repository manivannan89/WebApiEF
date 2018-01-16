using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Data;

namespace Application.Service.Services
{
    public interface IEmpService
    {
        List<EMP_DETAILS> GetEmpDetails();

        EMP_DETAILS GetEmpDetails(int id);

    }
}
