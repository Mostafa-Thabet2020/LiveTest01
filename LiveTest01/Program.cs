// See https://aka.ms/new-console-template for more information
using LiveTest01.ConsoleService;
using LiveTestDomain;

Console.WriteLine("Hello, World!");

string Result = DataSeed.StartSeeding();
 if(!string.IsNullOrEmpty(Result))
{
    Console.WriteLine(Result);
}


ConsoleService.DepartmentDealing();