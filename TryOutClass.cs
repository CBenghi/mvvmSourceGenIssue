using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;

namespace TryOut
{
	public partial class TryOutClass : ObservableObject
	{
		private int clickCount;

		// the ObservableProperty attribute should trigger the generation of the SomeValue property
		// (which is succesfully binded by the XAML in MainWindow)
		[ObservableProperty] 
		private string someValue = "Hi There";

		// the ICommand attribute creates a FunziaCommand at compile time that is
		// used in binding from the XAML in MainWindow
		[ICommand]
		private void Funzia()
		{
			// PROBLEM: The SomeValue property is generated programmatically and it is succesfully bound in XML
			// but it cannot be referenced here, or the compilation will fail.
			// This failure does happen if the project does not set <UseWPF>true</UseWPF>

			SomeValue = ""; 

			if (SetProperty(ref someValue, clickCount % 2 == 0 ? "Have a great day" : "Hi There", "SomeValue"))
            {
				clickCount++;
            }
		}
	}
}
