using System;

namespace Patterns_Adapter.WildCats {

	class Lion : IWildCat {
		public string Breed { get {
				return "Lion";
			}
		}

		public void Growl () {
			Console.WriteLine ("Grrrrrrrr");
		}

		public void Scratch () {
			Console.WriteLine ("I can kill you.");
		}
	}
}
