using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;

namespace TryOut
{
	public partial class TryOutClass : ObservableObject
	{
		private int clickCount;

		[ObservableProperty]
		private string someValue = "Hi There";

		[ICommand]
		private void Funzia()
		{
			if (SetProperty(ref someValue, clickCount % 2 == 0 ? "Have a great day" : "Hi There", "SomeValue"))
            {
				clickCount++;
            }
		}
	}
}
