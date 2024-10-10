

using BlazorStaff.Data;

namespace BlazorStaff.Repositories {
    public class StaffRepository : IStaffRepository
    {
        public StaffsContext staffsContext;

        public StaffRepository(StaffsContext context) {
            this.staffsContext = context;
        }

        public async Task<IEnumerable<Employee>> GetAllStaffs()
        {
            return staffsContext.Employees;
        }

        public async Task<Employee> GetStaff(int id)
        {
            return (from staff in staffsContext.Employees 
                    where staff.EmployeeId == id
                    select staff).First();
        }
    }
}