using System;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Components
{
	public partial class EmployeeCard
	{
		[Parameter]
		public Employee Employee { get; set; } = default!;

		[Parameter]
		public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

		public EmployeeCard()
		{
		}

		[Inject]
		public NavigationManager NavigationManager { get; set; } = default!;

		public void NavigateToDetails(Employee selectedEmployee) => this.NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
	}
}

