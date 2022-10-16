string name = "Hello World";

Console.WriteLine($"{name.Replace("World","Universe")}");
Console.WriteLine($"{name.ToUpper()}");

var result = name.Contains("World");

Console.WriteLine($"Does {name} contain World?  {result}");