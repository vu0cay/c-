namespace BlazorStaff.Components.Pages;

using BlazorStaff.Data;
using BlazorStaff.Repositories;
using Microsoft.AspNetCore.Components;

public class StaffListBase : ComponentBase
{
    public StaffsContext staffsContext;

    [Inject]
    public IStaffRepository staffRepository {get; set; }

    public IEnumerable<Employee> staffs {get; set;}
    

    protected override async Task OnInitializedAsync() { 
        staffs = await staffRepository.GetAllStaffs();
    }
    

}