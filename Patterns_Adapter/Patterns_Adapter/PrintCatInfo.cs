using System;
using Patterns_Adapter.HomeCats;

namespace Patterns_Adapter {

	public static class PrintCatInfo {

		public static void ShowCatInfo (IHomeCat cat) {
			Console.WriteLine (cat.Name);
			cat.Meow ();
			cat.Scratch ();
			Console.WriteLine ();
		}
	}
}
