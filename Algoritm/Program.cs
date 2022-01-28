// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, AlgoTrade!");
Algoritm1.lesson123.GetMainAlgoritm(5);
Console.WriteLine(Algoritm1.lesson123.StrangeSum(new int[] { 1, 2, 3, 4, 5 }));
Console.WriteLine("fibo методом цикла");
int n = 500;
Algoritm1.lesson123.FiboNumFor(ref n);
Console.WriteLine("Числа Фибоначчи мет рекурсии");
n = 500;
Algoritm1.lesson123.FiboNumRec(ref n);
Console.ReadKey();