using System.Text;

namespace KATA_Diamond
{
	public static class Diamond
	{
		private const byte startUpper = 65; // A
		private const byte startLower = 97; // a
		private const byte lastLower = 122; // z

		public static string Create(char letter)
		{
			// Error --> Only letters and basic ASCII table char
			if (!char.IsLetter(letter) || (byte)letter > lastLower)
			{
				return ":(";
			}

			// Handle a and A
			if (letter == startUpper || letter == startLower)
			{
				return letter.ToString();
			}

			// Handle Upper or Lower
			byte currentLetter = char.IsLower(letter) ? startLower : startUpper;

			byte startSpace = (byte)((byte)letter - currentLetter);
			byte middleSpace = 1;
			var sb = new StringBuilder();

			// Handle first line
			sb.Append(' ', startSpace--);
			sb.Append((char)currentLetter++);
			sb.AppendLine();

			while (currentLetter <= letter)
			{
				sb.Append(' ', startSpace);
				sb.Append((char)currentLetter);
				sb.Append(' ', middleSpace);
				sb.Append((char)currentLetter);
				sb.AppendLine();
				startSpace--;
				middleSpace += 2;
				currentLetter++;
			}

			// Split stringBuilder to reverse it
			var arr = sb.ToString().Split("\r\n");

			// Filling stringBuiilder with reverse array
			// -3 to skip last blank line and current letter line
			for (int i = arr.Length - 3; i >= 0; i--)
			{
				if (i == 0) // Handle last line of diamond, without \n
				{
					sb.Append(arr[i]);
				}
				else
				{
					sb.AppendLine(arr[i]);
				}
			}

			return sb.ToString();
		}

	}
}
