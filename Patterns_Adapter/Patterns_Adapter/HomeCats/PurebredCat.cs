using System;

namespace Patterns_Adapter.HomeCats {

	public class PurebredCat : IHomeCat {

		public string Name { get ; set ; }

		public void Meow () {
			Console.WriteLine ("Mrrrrrrrr");
		}

		public void Scratch () {
			Console.WriteLine ("I don't scratch.");
		}
	}
}
