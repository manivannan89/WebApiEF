using System;
using System.Collections.Generic;
using System.Linq;
using Application.Data;

namespace Application.Service.Services
{
    public class EmpService : IEmpService
    {

        private DEMO_MODELEntities db = new DEMO_MODELEntities();

        public List<EMP_DETAILS> GetEmpDetails()
        {
            return db.EMP_DETAILS.ToList();
        }

        public EMP_DETAILS GetEmpDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}