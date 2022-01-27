// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Algoritm.lesson1.MainAlgoritm(5);
Console.WriteLine(Algoritm.lesson1.StrangeSum(new int[] { 1, 2, 3, 4, 5 }));
Console.WriteLine("fibo методом цикла");
int n = 500;
Algoritm.lesson1.FiboNumFor(ref n);
Console.WriteLine("Числа Фибоначчи мет рекурсии");
n = 500;
Algoritm.lesson1.FiboNumRec(ref n);
Console.ReadKey();