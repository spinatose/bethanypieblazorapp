using System;
using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Pages
{
	public partial class EmployeeDetail
	{
        [Parameter]
		public string EmployeeId { get; set; }

		public Employee? Employee { get; set; } = new Employee();

		public EmployeeDetail()
		{
		}

        protected override Task OnInitializedAsync()
        {
			this.Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(this.EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}

