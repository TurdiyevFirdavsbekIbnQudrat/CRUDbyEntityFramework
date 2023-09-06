
using CRUDentity.EntityCRUD.CRUD;
using Dtos;
using EntityCRUD.CRUD;
var CompanyData2 = new companyDto()
{
    companyId = 1,
    name = "Windows",
    description = "Dasturlar yaratuvchi kompaniya",
    employeeId = 1,
};
var EmployeeData2 = new employeeDto()
{
    employeId = 1,
    firstname = "Quvvatbek",
    lastname = "Turdiyev",
    address = "Andijon",
    email = "Quvvatbek@gmail.com",

};
var staffData2 = new staffDto()
{
    staffId = 1,
    staffName = "Dasturchi",
};

/*var companyEntity = new CRUDcompany();
companyEntity.AddData(CompanyData2);*/
var employeeEntity = new CRUDemployee();
employeeEntity.AddData(EmployeeData2);