using TCS_Employee_Entity_CodeFirstApproach.Dtos;
using TCS_Employee_Entity_CodeFirstApproach.Entites;
using TCS_Employee_Entity_CodeFirstApproach.Interfaces;

namespace TCS_Employee_Entity_CodeFirstApproach.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartementRepository _departementRepository;
        public DepartmentService(IDepartementRepository departementRepository)
        {
            _departementRepository = departementRepository;
        }
        public async Task<int> AddDeparment(DepartementDto deptdetail)
        {
            Departement dept = new Departement();
            dept.deptid = deptdetail.deptid;
            dept.deptname = deptdetail.deptname;
            dept.deptlocation = deptdetail.deptlocation;
            var res = await _departementRepository.AddDeparment(dept);
            return res;
        }

        public async Task<bool> DeleteDepartmentById(int deptid)
        {
            await _departementRepository.DeleteDepartmentById(deptid);
            return true;
        }

        public async Task<List<DepartementDto>> GetDepartMentDetails()
        {

            List<DepartementDto> lisdeptDto = new List<DepartementDto>();
            var res = await _departementRepository.GetDepartMentDetails();
            foreach (Departement dept in res)
            {
                DepartementDto deptDto = new DepartementDto();
                deptDto.deptid = dept.deptid;
                deptDto.deptname = dept.deptname;
                deptDto.deptlocation = dept.deptlocation;
                lisdeptDto.Add(deptDto);

            }
            return lisdeptDto;

        }
        public async Task<DepartementDto> GetDepartmentDetailsById(int deptid)
        {
            var res = await _departementRepository.GetDepartmentDetailsById(deptid);
            DepartementDto deptDto = new DepartementDto();
            deptDto.deptid = res.deptid;
            deptDto.deptname = res.deptname;
            deptDto.deptlocation = res.deptlocation;
            return deptDto;
        }

        public async Task<bool> UpdateDepartment(DepartementDto deptdetail)
        {
            Departement dept = new Departement();
            dept.deptid = deptdetail.deptid;
            dept.deptname = deptdetail.deptname;
            dept.deptlocation = deptdetail.deptlocation;
            await _departementRepository.UpdateDepartment(dept);
            return true;
        }
    }
}
