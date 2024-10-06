// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Leovison!");


string anonymous = "Clark";
string anonnymous2 = "Mark";
string allNewFriends = $"Hi {anonymous} meet your new friend {anonnymous2}";

//String Methods - Replace()
Console.WriteLine(allNewFriends.Replace("Clark", "Shark"));

//String Methods - Contains
Console.WriteLine(allNewFriends.Contains("Clark"));

//String Methods - ToUpper and ToLower
Console.WriteLine(allNewFriends.ToUpper());
Console.WriteLine(allNewFriends.ToLower());

//String Methods - Length
Console.WriteLine(allNewFriends.Length);

//String Methods - StartsWith and EndsWith
Console.WriteLine(allNewFriends.StartsWith("Hi"));
Console.WriteLine(allNewFriends.StartsWith($"{anonnymous2}"));

//Reference = https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0#methods
