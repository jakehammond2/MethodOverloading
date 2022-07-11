

using MethodOverloading;

var sum = Methods.Add(7, 12);
Console.WriteLine(sum);

var sumDecimal = Methods.Add(.23, .45);
Console.WriteLine(sumDecimal);

var answer = Methods.Add(1, 0, true);
Console.WriteLine(answer); 