using Dtos;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Microsoft.EntityFrameworkCore;
using Models;
using EntityCRUD.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EntityCRUD.CRUD
{
    public class CRUDcompany : IDbFunctions<companyDto>
    {

        public async void AddData(companyDto DataWrite)
        {
            var com = new Company()
            {
                name = DataWrite.name,
                companyId = DataWrite.companyId,
                description = DataWrite.description,
                employeeId = DataWrite.employeeId,

            };
            var context = new AppDbContext();
          
           context.companies.Add(com);
           context.SaveChanges();
        }

        public void DeleteData(int Id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateData(companyDto DataWrite)
        {
            throw new NotImplementedException();
        }
    }
}
