using System;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.App.Components
{
	public partial class QuickViewPopup
	{
		[Parameter]
		public Employee? Employee { get; set; }
		private Employee? _employee;

		public QuickViewPopup()
		{
		}

        protected override void OnParametersSet() => this._employee = this.Employee;

		public void Close() => this._employee = null;
    }
}

