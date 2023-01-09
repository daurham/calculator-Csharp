// See https://aka.ms/new-console-template for more information
using System;


int run = Calculator.Program.Run("");
while (run == 1)
{
run = Calculator.Program.Run("");
}

namespace Calculator
{
  class Program
  {
    public static int Run(string args)
    {
      // CONSTANTS
      string operation;
      int arg1;
      int arg2;
      string result;
      string choice1;

      Console.Clear();
      // INTRODUCTION
      // INSERT ARGUMENT 1
      Console.WriteLine("C# Calculator:");
      Console.WriteLine("Enter argument 1:");
      Console.Write("> ");
      arg1 = Convert.ToInt32(Console.ReadLine());

      // INSERT OPERATION
      Console.Clear();
      Console.WriteLine("Enter an operation:");
      Console.WriteLine("(Possible operations: +, -, *, /, % )");
      Console.Write($"> {arg1} ");
      operation = Console.ReadLine();

      // INSERT ARGUMENT 2
      Console.Clear();
      Console.WriteLine("Enter argument 2:");
      Console.Write($"> {arg1} {operation} ");
      arg2 = Convert.ToInt32(Console.ReadLine());

      // OPERATE
      if (operation == "x" || operation == "*")
      {
        result = (arg1 * arg2).ToString();
      }
      else if (operation == "+")
      {
        result = (arg1 + arg2).ToString();
      }
      else if (operation == "/")
      {
        result = (arg1 / arg2).ToString();
      }
      else if (operation == "-")
      {
        result = (arg1 - arg2).ToString();
      }
      else if (operation == "%")
      {
        result = (arg1 % arg2).ToString();
      }
      else
      {
        result = "ERR";
      }

      // PRESENT THE RESULT
      Console.Clear();
      Console.WriteLine($"{arg1} {operation} {arg2} =");
      Console.WriteLine($"{result}");
      Console.WriteLine(); // Space

      // DETERMINE IF DONE OR RUN AGAIN
      Console.WriteLine("Again? (Y) or N");
      Console.Write("> ");
      choice1 = Console.ReadLine().ToLower();
      if (choice1 == "y" || choice1 == "yes" || choice1 == "")
      {
        Console.WriteLine(); // Space
        Console.WriteLine("Figure out how to *Loop back up*");
        // Console.Read();
        return 1;
      }
      else
      {
        Console.WriteLine(); // Space
        Console.WriteLine("Peace, nerd!");
        // Console.Read();
        return 0;
      }
    }
  }
}