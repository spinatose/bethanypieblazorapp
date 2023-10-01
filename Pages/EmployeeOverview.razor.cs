using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanyPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
	{
		public List<Employee>? Employees { get; set; } = default; 

		public EmployeeOverview()
		{
			Employees = MockDataService.Employees;
		}
	}
}