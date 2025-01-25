using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingClassLibrary
{

	[Serializable]
	public class InvalidFlavourException : Exception
	{
		public InvalidFlavourException() { }
		public InvalidFlavourException(string message) : base(message) { }
		public InvalidFlavourException(string message, Exception inner) : base(message, inner) { }
		protected InvalidFlavourException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
