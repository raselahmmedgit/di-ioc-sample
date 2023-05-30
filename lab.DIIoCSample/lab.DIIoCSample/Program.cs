// See https://aka.ms/new-console-template for more information
using lab.DIIoCSample;

Console.WriteLine("-Dependency Injection (DI) & Inversion of Control (IoC)-");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");

MSSql msSql = new MSSql();
//DatabaseContext databaseContext = new DatabaseContext(msSql);
Oracle oracle = new Oracle();
DatabaseContext databaseContext = new DatabaseContext(msSql);
databaseContext.ConnectDatabase();


Console.WriteLine("---------------------------End--------------------------");
Console.ReadLine();
