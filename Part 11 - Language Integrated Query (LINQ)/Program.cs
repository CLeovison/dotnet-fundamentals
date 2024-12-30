List<int> scores = [1, 2, 3, 4, 5, 6, 7];


//This is imperative,explicit 
// for (int i = 0; i < scores.Count; i++)
// {
//     if(scores[i] > i){
//         Console.WriteLine("Dadaaayms");
//     }else{
//         Console.WriteLine($"Here are the correct scores: {scores[i]}");
//     }
// }


//Introducing the Language Integrated Query (LINQ)

IEnumerable<int> scoreQuery = from score in scores
                              where score < 7
                              select score;

foreach(var i in scoreQuery){
    Console.WriteLine(i);
}