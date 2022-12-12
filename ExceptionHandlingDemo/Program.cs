using ExceptionHandlingDemo;
using NLog;

Logger logger = LogManager.GetLogger("Program");

Console.Write("First number: ");
var number1 = Console.ReadLine();
Console.Write("Second number: ");
var number2 = Console.ReadLine();

try
{
    //some code that could throw an exception
    var num1 = int.Parse(number1);
    var num2 = int.Parse(number2);

    var result = num1 / num2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}
catch(FormatException fex)
{
    //some code that will run if and only if an exception occurs
    logger.Error(fex, "An error has occured!");
}
catch(OverflowException)
{
    //logging
    Console.WriteLine("Number too big or too small");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Syntax error");
}
finally
{
    //some code that will run irrespective of whether an exception is thrown or not
    Console.WriteLine("Thank you for your patronage");
}
//Logs are system/application generated data

//Trace
//Debug
//Info
//Warn
//Error
//Fatal/Critical
//None

//log4net = Logger
//nlog
//serilog


//b => d => g
//