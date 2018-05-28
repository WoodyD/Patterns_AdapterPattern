using Patterns_Adapter.HomeCats;
using Patterns_Adapter.WildCats;

namespace Patterns_Adapter {

	public class HomeCatAdapted : IHomeCat {

		IWildCat _adaptedCat;

		public HomeCatAdapted (IWildCat adaptedCat) {
			_adaptedCat = adaptedCat;
		}

		public string Name { get {
				return _adaptedCat.Breed;
			}
			set { }
		}

		public void Meow () {
			_adaptedCat.Growl ();
		}

		public void Scratch () {
			_adaptedCat.Scratch ();
		}
	}
}
