//So What Are String? String is a sequence of characters, strong together and tied up together

string name = "Clark";

string secondname = "  Leovison  ";
secondname = secondname.Trim();

//String Methods
//TrimStart() = When you want to remove the whitespaces in the firstpart of string then this will be useful
//TrimEnd() =  When you want to remove the whitespaces in the lastpart of string then this will be useful
//Trim() =  When you want to remove the whitespaces in the firstpart and lastpart of string then this will be useful

//$ = String Interpolation in C# / Template String Literal in Javascript
Console.WriteLine($"Hi {name} {secondname} ");
