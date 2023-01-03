namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			int sum = count % 10;
			if (sum == 1) return "рубль";
			else if (sum > 1 && sum < 4) return "рубля";
			else return "рублей";
		}
	}
}