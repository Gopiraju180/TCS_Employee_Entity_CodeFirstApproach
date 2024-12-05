using TCS_Employee_Entity_CodeFirstApproach.Entites;

namespace TCS_Employee_Entity_CodeFirstApproach
{
    public interface IDepartementRepository
    {
        Task<List<Departement>> GetDepartMentDetails();
        Task<Departement> GetDepartmentDetailsById(int deptid);
        Task<int> AddDeparment(Departement deptdetail);
        Task<bool> DeleteDepartmentById(int deptid);
        Task<bool> UpdateDepartment(Departement deptdetail);
    }
}
