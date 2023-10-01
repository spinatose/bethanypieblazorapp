using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanyPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
	{
		public List<Employee>? Employees { get; set; } = default;

		private Employee? _selectedEmployee;

		public EmployeeOverview()
		{
			Employees = MockDataService.Employees;
		}

		public void ShowQuickViewPopup(Employee selectedEmployee)
		{
			this._selectedEmployee = selectedEmployee;
		}
	}
}