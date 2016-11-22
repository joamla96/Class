using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB06 {
	enum PetType {
		Cat,
		Dog
	}
	class Pet {
		public string Name { get; set; }
		public Enum Type { get; set; }
	}
}
