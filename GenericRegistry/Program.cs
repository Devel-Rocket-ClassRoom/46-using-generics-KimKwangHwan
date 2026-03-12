using System;

// 게임 점수 레지스트리
var scoreBoard = new Registry<string, int>(10);

// 점수 등록
scoreBoard.Register("철수", 1500);
scoreBoard.Register("영희", 2300);
scoreBoard.Register("민수", 1800);

Console.WriteLine("=== 점수 등록 완료 ===");
Console.WriteLine($"등록된 플레이어 수: {scoreBoard.Count}");
scoreBoard.PrintAll();

// 점수 조회
Console.WriteLine($"\n영희의 점수: {scoreBoard.Find("영희")}");
Console.WriteLine($"철수의 점수: {scoreBoard.Find("철수")}");

// 존재하지 않는 키 조회
Console.WriteLine($"존재하지 않는 키 조회: {scoreBoard.Find("길동")}");

// 키 존재 여부 확인
Console.WriteLine($"\n영희 존재 여부: {scoreBoard.Contains("영희")}");
Console.WriteLine($"길동 존재 여부: {scoreBoard.Contains("길동")}");

// 점수 갱신 (덮어쓰기)
scoreBoard.Register("철수", 2000);
Console.WriteLine($"\n철수 점수 갱신 후: {scoreBoard.Find("철수")}");
Console.WriteLine($"등록된 플레이어 수: {scoreBoard.Count}");