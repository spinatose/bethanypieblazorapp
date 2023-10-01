using System;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Components
{
	public partial class EmployeeCard
	{
		[Parameter]
		public Employee Employee { get; set; } = default!;
		public EmployeeCard()
		{
		}
	}
}

