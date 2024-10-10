using BlazorStaff.Data;

namespace BlazorStaff.Repositories 
{
    public interface IStaffRepository {
        Task<IEnumerable<Employee>> GetAllStaffs();
        Task<Employee> GetStaff(int id);
    }
}