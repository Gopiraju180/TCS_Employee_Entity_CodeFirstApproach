using TCS_Employee_Entity_CodeFirstApproach.Dtos;

namespace TCS_Employee_Entity_CodeFirstApproach.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartementDto>> GetDepartMentDetails();
        Task<DepartementDto> GetDepartmentDetailsById(int deptid);
        Task<int> AddDeparment(DepartementDto deptdetail);
        Task<bool> DeleteDepartmentById(int deptid);
        Task<bool> UpdateDepartment(DepartementDto deptdetail);
    }
}
