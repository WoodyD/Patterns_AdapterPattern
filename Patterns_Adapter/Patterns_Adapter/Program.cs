using System;
using Patterns_Adapter.HomeCats;
using Patterns_Adapter.WildCats;

namespace Patterns_Adapter {

	class Program {

		static void Main (string[] args) {

			var homeCat1 = new StreetCat {
				Name = "Tom"
			};

			var homeCat2 = new PurebredCat {
				Name = "Jack"
			};

			var wildCat = new HomeCatAdapted (new Lion ());

			PrintCatInfo.ShowCatInfo (homeCat1);
			PrintCatInfo.ShowCatInfo (homeCat2);
			PrintCatInfo.ShowCatInfo (wildCat);

			Console.ReadLine ();

		}
	}
}
