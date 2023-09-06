using Dtos;
using EntityCRUD.Data;
using Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDentity.EntityCRUD.CRUD
{
    public class CRUDemployee:IDbFunctions<employeeDto>
    {
        public async void AddData(employeeDto DataWrite)
        {
            var com = new Employee()
            {
                employeId = DataWrite.employeId,
                firstName = DataWrite.firstname,
                lastName = DataWrite.lastname,
                address = DataWrite.address,
                email = DataWrite.email,

            };
            var context = new AppDbContext();

            context.employees.Add(com);
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

        public void UpdateData(employeeDto DataWrite)
        {
            throw new NotImplementedException();
        }
    }
}
