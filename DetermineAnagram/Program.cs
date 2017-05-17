using System;

namespace DetermineAnagram
{
	class Program
	{
		static void Main ( string [ ] args )
		{
			//Get input for first word 
			Console.WriteLine ( "Please enter your first word :" );
			string firstWord = Console.ReadLine ( );

			//Get input for second word 
			Console.WriteLine ( "Please enter your second word :" );
			string secondWord = Console.ReadLine ( );
			
			bool isAnagram = DetermineAnagram.Determine ( firstWord , secondWord );

			if ( isAnagram )
			{
				Console.WriteLine ( $"{firstWord} is an anagram for {secondWord}" );
			}
			else
			{
				Console.WriteLine ( $"{firstWord} is not an anagram for {secondWord}" );
			}

			Console.Read( );

		}
		
	}
}
