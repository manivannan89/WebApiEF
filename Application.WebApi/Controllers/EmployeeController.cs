using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    public class EmployeeController : ApiController
    {

        private IEmpService empService = new EmpService();

        public IEnumerable<EMP_DETAILS> Get()
        {
            return empService.GetEmpDetails();
        }

    }
}
