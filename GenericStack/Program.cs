using System;

var intStack = new MyStack<int>(5);
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

Console.WriteLine("=== 정수 스택 테스트 ===");
Console.WriteLine($"Count: {intStack.Count}");
Console.WriteLine($"Peek: {intStack.Peek()}");
Console.WriteLine($"Pop: {intStack.Pop()}");
Console.WriteLine($"Pop: {intStack.Pop()}");
Console.WriteLine($"Count: {intStack.Count}");

// 문자열 스택 테스트
var stringStack = new MyStack<string>(5);
stringStack.Push("첫번째");
stringStack.Push("두번째");
stringStack.Push("세번째");

Console.WriteLine("\n=== 문자열 스택 테스트 ===");
Console.WriteLine($"Count: {stringStack.Count}");
Console.WriteLine($"Peek: {stringStack.Peek()}");
Console.WriteLine($"Pop: {stringStack.Pop()}");
Console.WriteLine($"IsEmpty: {stringStack.IsEmpty}");