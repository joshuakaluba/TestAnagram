using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetermineAnagram.Tests
{
	[TestClass]
	public class DetermineTests
	{
		[TestMethod]
		public void DetermineTestTrue( )
		{
			bool result = DetermineAnagram.Determine ( "Arrigo Boito" , "Tobia Gorrio" );

			Assert.IsTrue ( result );
		}

		[TestMethod]
		public void DetermineTestFalse ( )
		{
			bool result = DetermineAnagram.Determine ( "Not Anagram" , "Yeah Not Anagram" );

			Assert.IsFalse ( result );
		}
	}
}
