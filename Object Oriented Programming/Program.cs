using Object_Oriented_Programming;

// generalizarea tipului in C#
Data<int> FirstData = new Data<int>();
var fData1 = FirstData.Data1 = 1;
var fData2 = FirstData.Data2 = 2;
Console.WriteLine($"Sum of FirstData is:{fData2 + fData1}");
Console.ReadKey();

Data<string> SecondData = new Data<string>();
var sData1 = SecondData.Data1 = "1";
var sData2 = SecondData.Data2 = "2";
Console.WriteLine($"Sum of SecondData is:{sData2 + sData1}");
Console.ReadKey();