using System.Configuration;
using BlazorStaff.Data;
using BlazorStaff.Repositories;
using Microsoft.AspNetCore.Components;

namespace BlazorStaff.Components.Pages;

public class StaffDetailsBase : ComponentBase {

    public Employee staff {get; set;} = new Employee();
    [Inject]
    public IStaffRepository staffRepository {get; set;}
    [Parameter]
    public String Id {get; set;}

    protected async override Task OnInitializedAsync() {
        Id = Id ?? "1";
        staff = await staffRepository.GetStaff(int.Parse(Id));
    }

}