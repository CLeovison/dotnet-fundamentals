//Integer or int can only store 32bit integer which means the maximum number that int can only handle is up to 2Biliion and above that 
//it cannot be handle by the integer for long number you can use the long type inorder to be handle properly
long a = 2100000000;
long b = 2100000000;

//So the main reason why it doesn't work was because it was stored in the integer and the type that you are storing the a + b is long which 
//means it can cause error so in order to fix that you can use long on the integer number
long c = a + b;

Console.WriteLine(c);
//Output: 4200000000



// int a = 2100000000;
// int b = 2100000000;

// long c = a + b;
// //Output: -94967296