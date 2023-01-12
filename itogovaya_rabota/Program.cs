var text = new string[] { "hello", "2", "World", ":-)" };

string[] group = Array.FindAll(text, word => word.Length <= 3);
foreach (var word in group);
