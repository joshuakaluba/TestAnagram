using System;

namespace DetermineAnagram
{
	public static class DetermineAnagram
	{
		public static bool Determine ( string firstWord , string secondWord )
		{
			//Convert both parameters to uppercase strings
			firstWord = firstWord.ToUpper ( ).Trim ( );
			secondWord = secondWord.ToUpper ( ).Trim ( );

			//remove any spaces from the strings just in case the anagram
			//is more than one word long
			firstWord = firstWord.Replace ( " " , "" );
			secondWord = secondWord.Replace ( " " , "" );

			//if the length of both words is not the same, they are 
			//not an anagram and we can return
			if ( firstWord.Length != secondWord.Length )
			{
				return false;
			}

			//convert both strings to a char array
			char [ ] firstWordCharArray = firstWord.ToCharArray ( );
			char [ ] secondWordCharArray = secondWord.ToCharArray ( );

			//sort the arrays
			Array.Sort ( firstWordCharArray );
			Array.Sort ( secondWordCharArray );

			for ( int Count = 0 ; Count < firstWordCharArray.Length ; Count++ )
			{
				//loop through each character in our first array and check 
				//that the corresponding character in the second array matches,                
				if ( firstWordCharArray [ Count ] != secondWordCharArray [ Count ] )
				{
					//if there is no match, we do not have an anagram.
					return false;
				}
			}

			//if we have a match for every character in the arrays, we have an anagram
			return true;
		}
	}
}
