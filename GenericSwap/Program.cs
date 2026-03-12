using System;

// Swap 테스트
int x = 10, y = 20;
Console.WriteLine($"교환 전: x={x}, y={y}");
Utils.Swap(ref x, ref y);
Console.WriteLine($"교환 후: x={x}, y={y}");

string a = "Hello", b = "World";
Console.WriteLine($"\n교환 전: a={a}, b={b}");
Utils.Swap(ref a, ref b);
Console.WriteLine($"교환 후: a={a}, b={b}");

// SwapInArray 테스트
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine($"\n배열 교환 전: [{string.Join(", ", numbers)}]");
Utils.SwapInArray(numbers, 0, 4);
Console.WriteLine($"배열 교환 후: [{string.Join(", ", numbers)}]");

// FindMin, FindMax 테스트
int[] scores = { 85, 92, 78, 95, 88 };
Console.WriteLine($"\n점수: [{string.Join(", ", scores)}]");
Console.WriteLine($"최소값: {Utils.FindMin(scores)}");
Console.WriteLine($"최대값: {Utils.FindMax(scores)}");

string[] words = { "banana", "apple", "cherry" };
Console.WriteLine($"\n단어: [{string.Join(", ", words)}]");
Console.WriteLine($"사전순 첫 단어: {Utils.FindMin(words)}");
Console.WriteLine($"사전순 끝 단어: {Utils.FindMax(words)}");

// Reverse 테스트
int[] data = { 1, 2, 3, 4, 5 };
Console.WriteLine($"\n뒤집기 전: [{string.Join(", ", data)}]");
Utils.Reverse(data);
Console.WriteLine($"뒤집기 후: [{string.Join(", ", data)}]");