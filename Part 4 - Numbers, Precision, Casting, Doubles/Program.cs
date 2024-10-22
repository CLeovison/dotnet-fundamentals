//int a = 42.1;
//Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)

//Inorder to fix this problem, you need to use double or float
//Float is widely use specially in currency

// double a = 42.1; //Natural Type
// float b = 38.2f;
// double c = checked(a+b);
// Console.WriteLine(c);

decimal a = 42.1M;//Explicit Type
decimal b = 38.2M;
decimal c = (a+b);
Console.WriteLine(c);

Console.WriteLine($"This is the final answer {c}");
//Reference : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

//Real literals
// The type of a real literal is determined by its suffix as follows:

// The literal without suffix or with the d or D suffix is of type double
// The literal with the f or F suffix is of type float
// The literal with the m or M suffix is of type decimal