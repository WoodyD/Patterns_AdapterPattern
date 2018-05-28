using System;

namespace Patterns_Adapter.HomeCats {

	public class StreetCat : IHomeCat {

		public string Name { get ; set ; }

		public void Meow () {
			Console.WriteLine ("Meow, meow!!!");
		}

		public void Scratch () {
			Console.WriteLine ("I can scratch.");
		}
	}
}
