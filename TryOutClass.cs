using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;

namespace TryOut
{
	public partial class TryOutClass : ObservableObject
	{
		[ObservableProperty]
		private string someValue;

		[ICommand]
		private void Funzia()
		{
			SomeValue = "newValue";
		}
	}
}
