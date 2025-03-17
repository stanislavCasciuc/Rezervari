string filePath = "words.txt";
if (!File.Exists(filePath))
{
  Console.WriteLine("File not found!");
  return;
}

string[] words = File.ReadAllLines(filePath)
                     .SelectMany(line => line.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                     .ToArray();

List<string>[] categorizedWords = new List<string>[26];
for (int i = 0; i < 26; i++)
{
  categorizedWords[i] = new List<string>();
}

foreach (string word in words)
{
  char firstChar = char.ToLower(word[0]);
  if (firstChar >= 'a' && firstChar <= 'z')
  {
    int index = firstChar - 'a';
    categorizedWords[index].Add(word);
  }
}

for (int i = 0; i < 26; i++)
{
  char letter = (char)('a' + i);
  Console.WriteLine($"Words starting with '{letter}':");
  foreach (string word in categorizedWords[i])
  {
    Console.WriteLine(word);
  }
  Console.WriteLine();
}
