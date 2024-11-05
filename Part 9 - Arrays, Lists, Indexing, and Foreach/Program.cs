//List of <T> Procedure

//First if you want to declare a new List then you must put List and then specify the type,
//If you don't know what the type is then just put <T>

var names = new List<string> { "Clark", "Cedric", "Carlo" };

//Second if you want to add a new item in the collection then you can use add or any methods.
names.Add("Daymn");
names.Add("Mark");

//Chord = If you want to comment the line then press Ctrl K + C
//If you want to uncomment the code or line then ctrl k + U 

// foreach(var name in names){
//     Console.WriteLine($"Hello {name}");
// } 

//Implicit operator
// foreach (var name in names[2..4]){
//     Console.WriteLine($"Hello {name}");
// }



//So in this example to access the first and fourth element of the List you can use Array.

// Console.WriteLine(names[1]);
// Console.WriteLine(names[4]);

//So the reason behind this is that after getting all the list then it will get the last one
// Console.WriteLine(names[names.Count - 1]);

//This means count from the back of the array
// Console.WriteLine(names[^2]);


//Using arrays



var newNames = new string[] { "Carlo", "Jonathan", "Allen" };
//Arrays are fixed length
// newNames.Add("Cedric"); //'string[]' does not contain a definition for 'Add' and no accessible extension method 'Add' accepting a first argument of type 'string[]' could be found (are you missing a using directive or an assembly reference?)

//This kind of method uses a lot of memory
newNames = [..newNames,"Ralph"];


foreach (var name in newNames)
{
    Console.WriteLine($"Hello {name}");
}


//So the question is when do i pick array of strings and array of list
//The most convenient thing to use is List since you can change it and you can add and remove it

//Using arrays is convienient is you want to use a fixed memory or you have a fixed size of list